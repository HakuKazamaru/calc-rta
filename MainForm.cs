namespace CalcRTA
{
    /// <summary>
    /// �d��t�H�[��
    /// </summary>
    public partial class MainForm : Form
    {
        #region �����o�[�ϐ�
        /// <summary>
        /// �v�Z�ς݂̐��l�i�����v�Z�p�j
        /// </summary>
        private double CalcedNumber = 0.0;
        /// <summary>
        /// ��ʏ�̐��l�i�����v�Z�p�j
        /// </summary>
        private double PanelNumber = 0.0;
        /// <summary>
        /// �O����͂��ꂽ���l�i�����v�Z�p�j
        /// </summary>
        private double InputedNumber = 0.0;
        /// <summary>
        /// �v�Z���[�h�Ǘ��p
        /// </summary>
        private int CalcMode = 0;
        /// <summary>
        /// ���O���̓{�^���Ǘ��p
        /// </summary>
        private int InputButton = 0;
        /// <summary>
        /// �v�Z�\�t���O�Ǘ��p
        /// </summary>
        private bool CanCalcFlag = false;
        /// <summary>
        /// ���͏�ԊǗ��p
        /// </summary>
        private bool InputMode = false;
        /// <summary>
        /// �����_��ԊǗ��p
        /// </summary>
        private bool FloatMode = false;
        /// <summary>
        /// �����_��ԊǗ��p
        /// </summary>
        private bool PercentMode = false;
        #endregion

        /// <summary>
        /// �R���X�g���N�^�[
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// �S�������p���\�b�h
        /// </summary>
        private void Initialize()
        {
            PanelInitialize();
        }

        /// <summary>
        /// �p�l���i��ʁj�������p
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
        /// �S�N���A�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClearErase_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        /// <summary>
        /// �N���A�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            PanelInitialize();
        }

        /// <summary>
        /// �o�b�N�X�y�[�X�{�^������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBackspace_Click(object sender, EventArgs e)
        {
            if (InputMode)
            {
                if (this.tbOutputPanel.Text.Length > 1)
                {
                    // ���͏�Ԃ̏ꍇ���APanel�̕�������1������葽���Ƃ��ꕶ������
                    this.tbOutputPanel.Text = this.tbOutputPanel.Text.Substring(0, this.tbOutputPanel.Text.Length - 1);
                    double.TryParse(this.tbOutputPanel.Text, out PanelNumber);
                }
                else
                {
                    // ���͏�Ԃ̏ꍇ���APanel�̕�������2���������̂Ƃ��u0�v����
                    this.tbOutputPanel.Text = "0";
                    PanelNumber = 0.0;
                }
            }
            else
            {
                // �����͏�Ԃ̂Ƃ��͌v�Z���[�h������������
                CalcMode = 0;
            }
            InputButton = 0;
        }

        /// <summary>
        /// �����u0�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber0_Click(object sender, EventArgs e)
        {
            InputNumber(0);
        }

        /// <summary>
        /// �����u1�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber1_Click(object sender, EventArgs e)
        {
            InputNumber(1);
        }

        /// <summary>
        /// �����u2�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber2_Click(object sender, EventArgs e)
        {
            InputNumber(2);
        }

        /// <summary>
        /// �����u3�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber3_Click(object sender, EventArgs e)
        {
            InputNumber(3);
        }

        /// <summary>
        /// �����u4�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber4_Click(object sender, EventArgs e)
        {
            InputNumber(4);
        }

        /// <summary>
        /// �����u5�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber5_Click(object sender, EventArgs e)
        {
            InputNumber(5);
        }

        /// <summary>
        /// �����u6�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber6_Click(object sender, EventArgs e)
        {
            InputNumber(6);
        }

        /// <summary>
        /// �����u7�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber7_Click(object sender, EventArgs e)
        {
            InputNumber(7);
        }

        /// <summary>
        /// �����u8�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber8_Click(object sender, EventArgs e)
        {
            InputNumber(8);
        }

        /// <summary>
        /// �����u9�v�{�^���N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNumber9_Click(object sender, EventArgs e)
        {
            InputNumber(9);
        }

        /// <summary>
        /// �{�^�����͎��̏���
        /// </summary>
        private void InputNumber(int inputNumber)
        {
            if (InputButton != 0)
            {
                // ���̓{�^������������Ȃ��Ƃ��͑��
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
                    // ���̓{�^���������Ŗ����͎��͑��
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
                    // ���̓{�^���������œ��͍ς݂̂Ƃ��͒l��A��
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
        /// �v�Z�p���\�b�h
        /// </summary>
        private void Calc()
        {
            if (CanCalcFlag)
            {
                switch (CalcMode)
                {
                    case 0:
                        goto default;
                    case 1: //�����Z��
                        CalcedNumber += InputedNumber;
                        break;
                    case 2: //�����Z��
                        CalcedNumber -= InputedNumber;
                        break;
                    case 3: //�|���Z��
                        CalcedNumber *= InputedNumber;
                        break;
                    case 4: //����Z��
                        CalcedNumber /= InputedNumber;
                        break;
                    default: // ���v�Z��
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
        /// �����Z�{�^���N���b�N���̏���
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
        /// �����Z�{�^���N���b�N���̏���
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
        /// �|���Z�{�^���N���b�N���̏���
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
        /// ����Z�{�^���N���b�N���̏���
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
        /// �C�R�[���{�^���N���b�N���̏���
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
        /// �����_���͂ւ̐؂�ւ��{�^���N���b�N���̏���
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
        /// �p�[�Z���g�֊��Z����{�^���N���b�N���̏���
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