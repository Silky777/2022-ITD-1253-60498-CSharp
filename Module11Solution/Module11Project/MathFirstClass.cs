using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Project
{
    class MathFirstClass
    {
        const byte BYTE = 1;
        const byte SHORT = 2;
        const byte INT = 3;
        const byte LONG = 4;
        const byte FLOAT = 5;
        const byte DOUBLE = 6;
        const byte DECIMAL = 7;
        byte byteRight, byteLeft;
        short shortRight, shortLeft;
        int intRight, intLeft;
        long longRight, longLeft;
        float floatRight, floatLeft;
        double doubleRight, doubleLeft;
        decimal decimalRight, decimalLeft;

        private string _LeftText;
        public string LeftText
        {
            get { return _LeftText; }
            set { _LeftText = value; }
        }
        private string _RightText;
        public string RightText
        {
            get { return _RightText; }
            set { _RightText = value; }
        }
        private byte _NumType = 0;
        public byte NumType
        {
            get { return _NumType; }
            set { _NumType = value; }
        }

        public string AddOperands()
        {
            decimal result = 0;
            if (_NumType == BYTE)
            {
                byteLeft = Convert.ToByte(_LeftText);
                byteRight = Convert.ToByte(_RightText);
                result = byteLeft + byteRight;
            }
            if(_NumType == SHORT)
            {
                shortLeft = Convert.ToInt16(_LeftText);
                shortRight = Convert.ToInt16(_RightText);
                result = shortLeft + shortRight;
            }
            if (_NumType == INT)
            {
                intLeft = Convert.ToInt32(_LeftText);
                intRight = Convert.ToInt32(_RightText);
                result = intLeft + intRight;
            }
            if (_NumType == LONG)
            {
                longLeft = Convert.ToInt64(_LeftText);
                longRight = Convert.ToInt64(_RightText);
                result = longLeft + longRight;
            }
            if (_NumType == FLOAT)
            {
                floatLeft = Convert.ToSingle(_LeftText);
                floatRight = Convert.ToSingle(_RightText);
                result = Convert.ToDecimal(floatLeft + floatRight);
            }
            if (_NumType == DOUBLE)
            {
                doubleLeft = Convert.ToDouble(_LeftText);
                doubleRight = Convert.ToDouble(_RightText);
                result = Convert.ToDecimal(doubleLeft + doubleRight);
            }
            if (_NumType == DECIMAL)
            {
                decimalLeft = Convert.ToDecimal(_LeftText);
                decimalRight = Convert.ToDecimal(_RightText);
                result = decimalLeft + decimalRight;
            }
            return $"{_LeftText} + {_RightText} = {result}";
        }
        public string SubtractOperands()
        {
            decimal result = 0;
            if (_NumType == BYTE)
            {
                byteLeft = Convert.ToByte(_LeftText);
                byteRight = Convert.ToByte(_RightText);
                result = byteLeft - byteRight;
            }
            if (_NumType == SHORT)
            {
                shortLeft = Convert.ToInt16(_LeftText);
                shortRight = Convert.ToInt16(_RightText);
                result = shortLeft - shortRight;
            }
            if (_NumType == INT)
            {
                intLeft = Convert.ToInt32(_LeftText);
                intRight = Convert.ToInt32(_RightText);
                result = intLeft - intRight;
            }
            if (_NumType == LONG)
            {
                longLeft = Convert.ToInt64(_LeftText);
                longRight = Convert.ToInt64(_RightText);
                result = longLeft - longRight;
            }
            if (_NumType == FLOAT)
            {
                floatLeft = Convert.ToSingle(_LeftText);
                floatRight = Convert.ToSingle(_RightText);
                result = Convert.ToDecimal(floatLeft - floatRight);
            }
            if (_NumType == DOUBLE)
            {
                doubleLeft = Convert.ToDouble(_LeftText);
                doubleRight = Convert.ToDouble(_RightText);
                result = Convert.ToDecimal(doubleLeft - doubleRight);
            }
            if (_NumType == DECIMAL)
            {
                decimalLeft = Convert.ToDecimal(_LeftText);
                decimalRight = Convert.ToDecimal(_RightText);
                result = decimalLeft - decimalRight;
            }
            return $"{_LeftText} - {_RightText} = {result}";
        }
        public string MultiplyOperands()
        {
            decimal result = 0;
            if (_NumType == BYTE)
            {
                byteLeft = Convert.ToByte(_LeftText);
                byteRight = Convert.ToByte(_RightText);
                result = byteLeft * byteRight;
            }
            if (_NumType == SHORT)
            {
                shortLeft = Convert.ToInt16(_LeftText);
                shortRight = Convert.ToInt16(_RightText);
                result = shortLeft * shortRight;
            }
            if (_NumType == INT)
            {
                intLeft = Convert.ToInt32(_LeftText);
                intRight = Convert.ToInt32(_RightText);
                result = intLeft * intRight;
            }
            if (_NumType == LONG)
            {
                longLeft = Convert.ToInt64(_LeftText);
                longRight = Convert.ToInt64(_RightText);
                result = longLeft * longRight;
            }
            if (_NumType == FLOAT)
            {
                floatLeft = Convert.ToSingle(_LeftText);
                floatRight = Convert.ToSingle(_RightText);
                result = Convert.ToDecimal(floatLeft * floatRight);
            }
            if (_NumType == DOUBLE)
            {
                doubleLeft = Convert.ToDouble(_LeftText);
                doubleRight = Convert.ToDouble(_RightText);
                result = Convert.ToDecimal(doubleLeft * doubleRight);
            }
            if (_NumType == DECIMAL)
            {
                decimalLeft = Convert.ToDecimal(_LeftText);
                decimalRight = Convert.ToDecimal(_RightText);
                result = decimalLeft * decimalRight;
            }
            return $"{_LeftText} * {_RightText} = {result}";
        }
        public string DivideOperands()
        {
            decimal result = 0;
            if (_NumType == BYTE)
            {
                byteLeft = Convert.ToByte(_LeftText);
                byteRight = Convert.ToByte(_RightText);
                result = byteLeft / byteRight;
            }
            if (_NumType == SHORT)
            {
                shortLeft = Convert.ToInt16(_LeftText);
                shortRight = Convert.ToInt16(_RightText);
                result = shortLeft / shortRight;
            }
            if (_NumType == INT)
            {
                intLeft = Convert.ToInt32(_LeftText);
                intRight = Convert.ToInt32(_RightText);
                result = intLeft / intRight;
            }
            if (_NumType == LONG)
            {
                longLeft = Convert.ToInt64(_LeftText);
                longRight = Convert.ToInt64(_RightText);
                result = longLeft / longRight;
            }
            if (_NumType == FLOAT)
            {
                floatLeft = Convert.ToSingle(_LeftText);
                floatRight = Convert.ToSingle(_RightText);
                result = Convert.ToDecimal(floatLeft / floatRight);
            }
            if (_NumType == DOUBLE)
            {
                doubleLeft = Convert.ToDouble(_LeftText);
                doubleRight = Convert.ToDouble(_RightText);
                result = Convert.ToDecimal(doubleLeft / doubleRight);
            }
            if (_NumType == DECIMAL)
            {
                decimalLeft = Convert.ToDecimal(_LeftText);
                decimalRight = Convert.ToDecimal(_RightText);
                result = decimalLeft / decimalRight;
            }
            return $"{_LeftText} / {_RightText} = {result}";
        }
        public string ModulusOperands()
        {
            decimal result = 0;
            if (_NumType == BYTE)
            {
                byteLeft = Convert.ToByte(_LeftText);
                byteRight = Convert.ToByte(_RightText);
                result = byteLeft % byteRight;
            }
            if (_NumType == SHORT)
            {
                shortLeft = Convert.ToInt16(_LeftText);
                shortRight = Convert.ToInt16(_RightText);
                result = shortLeft % shortRight;
            }
            if (_NumType == INT)
            {
                intLeft = Convert.ToInt32(_LeftText);
                intRight = Convert.ToInt32(_RightText);
                result = intLeft % intRight;
            }
            if (_NumType == LONG)
            {
                longLeft = Convert.ToInt64(_LeftText);
                longRight = Convert.ToInt64(_RightText);
                result = longLeft % longRight;
            }
            if (_NumType == FLOAT)
            {
                floatLeft = Convert.ToSingle(_LeftText);
                floatRight = Convert.ToSingle(_RightText);
                result = Convert.ToDecimal(floatLeft % floatRight);
            }
            if (_NumType == DOUBLE)
            {
                doubleLeft = Convert.ToDouble(_LeftText);
                doubleRight = Convert.ToDouble(_RightText);
                result = Convert.ToDecimal(doubleLeft % doubleRight);
            }
            if (_NumType == DECIMAL)
            {
                decimalLeft = Convert.ToDecimal(_LeftText);
                decimalRight = Convert.ToDecimal(_RightText);
                result = decimalLeft % decimalRight;
            }
            return $"{_LeftText} % {_RightText} = {result}";
        }
    }
}
