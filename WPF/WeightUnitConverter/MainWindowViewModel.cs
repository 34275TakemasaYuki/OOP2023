using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeightUnitConverter {
    public class MainWindowViewModel : ViewModel{
        private double gramValue, pondValue;

        public double GramValue
        {
            get { return this.gramValue; }
            set
            {
                this.gramValue = value;
                this.OnPropertyChanged();
            }
        }

        public double PondValue
        {
            get { return this.pondValue; }
            set
            {
                this.pondValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のコンボボックスで選択されている値(単位)
        public GramUnit CurrentGramUnit { get; set; }

        //下のコンボボックスで選択されている値(単位)
        public PondUnit CurrentPondUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand PondUnitToGram { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand GramUnitToPond { get; private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentGramUnit = GramUnit.Units.First();
            this.CurrentPondUnit = PondUnit.Units.First();

            this.GramUnitToPond = new DelegateCommand(
                () => this.PondValue = this.CurrentPondUnit.FromGramUnit(
                    this.CurrentGramUnit, this.GramValue));

            this.PondUnitToGram = new DelegateCommand(
                () => this.GramValue = this.CurrentGramUnit.FromPondUnit(
                    this.CurrentPondUnit, this.PondValue));
        }
    }
}
