using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_02
{
    
        //Xác định giá trị từng ô cờ [null, X, O]
        public enum FIELD { FLD_EMPTY = ' ', FLD_X = 'X', FLD_O = 'O' }
        public class Cell
        {
            FIELD fieldState = FIELD.FLD_EMPTY;
            //khởi tạo mặc định ô cờ là null
            public Cell(FIELD fieldState = FIELD.FLD_EMPTY) { this.FieldState = fieldState; }
            //getter/setter
            public FIELD FieldState { get => fieldState; set => fieldState = value; }
            //kiểm tra ô cờ đang rỗng
            public bool isEmpty() { return (fieldState == FIELD.FLD_EMPTY); }
            //điền dấu người chơi vào ô
            public void markField(char c)
            {
                if (c == 'X')        fieldState = FIELD.FLD_X;
                else if (c == 'O') fieldState = FIELD.FLD_O;
                else fieldState = FIELD.FLD_EMPTY;
            }
        }
    }

