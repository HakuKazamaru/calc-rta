namespace CalcRTA
{
    /// <summary>
    /// 電卓フォーム
    /// </summary>
    public partial class MainForm : Form
    {
        #region メンバー変数
        /// <summary>
        /// 計算済みの数値（内部計算用）
        /// </summary>
        private double CalcedNumber = 0.0;
        /// <summary>
        /// 画面上の数値（内部計算用）
        /// </summary>
        private double PanelNumber = 0.0;
        /// <summary>
        /// 前回入力された数値（内部計算用）
        /// </summary>
        private double InputedNumber = 0.0;
        /// <summary>
        /// 計算モード管理用
        /// </summary>
        private int CalcMode = 0;
        /// <summary>
        /// 直前入力ボタン管理用
        /// </summary>
        private int InputButton = 0;
        /// <summary>
        /// 計算可能フラグ管理用
        /// </summary>
        private bool CanCalcFlag = false;
        /// <summary>
        /// 入力状態管理用
        /// </summary>
        private bool InputMode = false;
        /// <summary>
        /// 小数点状態管理用
        /// </summary>
        private bool FloatMode = false;
        /// <summary>
        /// 小数点状態管理用
        /// </summary>
        private bool PercentMode = false;
        #endregion

        /// <summary>
        /// コンストラクター
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 全初期化用メソッド
        /// </summary>
        private void Initialize()
        {
            PanelInitialize();
        }

        /// <summary>
        /// パネル（画面）初期化用
        /// </summary>
        private void PanelInitialize()
        {
            CanCalcFlag = false;
            InputMode = false;
            FloatMode = false;
            PercentMode = false;

            CalcedNumber = 0.0;
            PanelNumber = 0.0;
            InputedNumber = 0.0;

            CalcMode = 0;
            InputButton = 0;

            this.tbOutputPanel.Text = "0";
        }

        /// <summary>
        /// 全クリアボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClearErase_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        /// <summary>
        /// クリアボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            PanelInitialize();
        }

        /// <summary>
        /// バックスペースボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBackspace_Click(object sender, EventArgs e)
        {
            if (InputMode)
            {
                if (this.tbOutputPanel.Text.Length > 1)
                {
                    // 入力状態の場合かつ、Panelの文字数が1文字より多いとき一文字消す
                    this.tbOutputPanel.Text = this.tbOutputPanel.Text.Substring(0, this.tbOutputPanel.Text.Length - 1);
                    double.TryParse(this.tbOutputPanel.Text, out PanelNumber);
                }
                else
                {
                    // 入力状態の場合かつ、Panelの文字数が2文字未満のとき「0」を代入
                    this.tbOutputPanel.Text = "0";
                    PanelNumber = 0.0;
                }
            }
            else
            {
                // 未入力状態のときは計算モードを初期化する
                CalcMode = 0;
            }
            InputButton = 0;
        }

        /// <summary>
        /// 数字「0」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber0_Click(object sender, EventArgs e)
        {
            InputNumber(0);
        }

        /// <summary>
        /// 数字「1」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber1_Click(object sender, EventArgs e)
        {
            InputNumber(1);
        }

        /// <summary>
        /// 数字「2」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber2_Click(object sender, EventArgs e)
        {
            InputNumber(2);
        }

        /// <summary>
        /// 数字「3」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber3_Click(object sender, EventArgs e)
        {
            InputNumber(3);
        }

        /// <summary>
        /// 数字「4」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber4_Click(object sender, EventArgs e)
        {
            InputNumber(4);
        }

        /// <summary>
        /// 数字「5」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber5_Click(object sender, EventArgs e)
        {
            InputNumber(5);
        }

        /// <summary>
        /// 数字「6」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber6_Click(object sender, EventArgs e)
        {
            InputNumber(6);
        }

        /// <summary>
        /// 数字「7」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber7_Click(object sender, EventArgs e)
        {
            InputNumber(7);
        }

        /// <summary>
        /// 数字「8」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber8_Click(object sender, EventArgs e)
        {
            InputNumber(8);
        }

        /// <summary>
        /// 数字「9」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber9_Click(object sender, EventArgs e)
        {
            InputNumber(9);
        }

        /// <summary>
        /// ボタン入力時の処理
        /// </summary>
        private void InputNumber(int inputNumber)
        {
            if (InputButton != 0)
            {
                // 入力ボタンが数字じゃないときは代入
                PanelNumber = inputNumber;
                this.tbOutputPanel.Text = PanelNumber.ToString();
            }
            else
            {
                double tmpValue = 0.0;
                bool fastFloatInput = false;
                double.TryParse(this.tbOutputPanel.Text, out tmpValue);

                if (FloatMode && this.tbOutputPanel.Text.Substring(this.tbOutputPanel.Text.Length - 2, 2) == ".0")
                {
                    fastFloatInput = true;
                }

                if (tmpValue == 0.0)
                {
                    // 入力ボタンが数字で未入力時は代入
                    if (fastFloatInput)
                    {
                        PanelNumber = inputNumber * 0.1;
                    }
                    else
                    {
                        PanelNumber = inputNumber;
                    }
                    this.tbOutputPanel.Text = PanelNumber.ToString();
                }
                else
                {
                    // 入力ボタンが数字で入力済みのときは値を連結
                    if (fastFloatInput)
                    {
                        this.tbOutputPanel.Text = this.tbOutputPanel.Text.Substring(0, this.tbOutputPanel.Text.Length - 1) + inputNumber;
                    }
                    else
                    {
                        this.tbOutputPanel.Text += inputNumber;
                    }
                    double.TryParse(this.tbOutputPanel.Text, out PanelNumber);
                }
            }

            InputedNumber = PanelNumber;
            InputButton = 0;
            InputMode = true;
        }

        /// <summary>
        /// 計算用メソッド
        /// </summary>
        private void Calc()
        {
            if (CanCalcFlag)
            {
                switch (CalcMode)
                {
                    case 0:
                        goto default;
                    case 1: //足し算時
                        CalcedNumber += InputedNumber;
                        break;
                    case 2: //引き算時
                        CalcedNumber -= InputedNumber;
                        break;
                    case 3: //掛け算時
                        CalcedNumber *= InputedNumber;
                        break;
                    case 4: //割り算時
                        CalcedNumber /= InputedNumber;
                        break;
                    default: // 未計算時
                        CalcedNumber = InputedNumber;
                        break;
                }
                this.tbOutputPanel.Text = CalcedNumber.ToString();
            }
            else
            {
                CalcedNumber = InputedNumber;
                CanCalcFlag = true;
            }
            PercentMode = false;
            FloatMode = false;
        }

        /// <summary>
        /// 足し算ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlus_Click(object sender, EventArgs e)
        {
            InputButton = 1;
            Calc();
            CalcMode = 1;
        }

        /// <summary>
        /// 引き算ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMinus_Click(object sender, EventArgs e)
        {
            InputButton = 2;
            Calc();
            CalcMode = 2;
        }

        /// <summary>
        /// 掛け算ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMultiplication_Click(object sender, EventArgs e)
        {
            InputButton = 3;
            Calc();
            CalcMode = 3;
        }

        /// <summary>
        /// 割り算ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDivide_Click(object sender, EventArgs e)
        {
            InputButton = 4;
            Calc();
            CalcMode = 4;
        }

        /// <summary>
        /// イコールボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEqual_Click(object sender, EventArgs e)
        {
            InputButton = CalcMode;
            Calc();
            PanelNumber = CalcedNumber;
            this.tbOutputPanel.Text = PanelNumber.ToString();
        }

        /// <summary>
        /// 小数点入力への切り替えボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPoint_Click(object sender, EventArgs e)
        {
            if (!FloatMode)
            {
                FloatMode = true;
                this.tbOutputPanel.Text += ".0";
            }
            InputButton = 0;
        }

        /// <summary>
        /// パーセントへ換算するボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPercent_Click(object sender, EventArgs e)
        {
            if (!PercentMode)
            {
                PanelNumber *= 0.01;
                InputedNumber = PanelNumber;
                this.tbOutputPanel.Text = PanelNumber.ToString();
                PercentMode = true;
            }
            InputButton = 0;
        }
    }
}