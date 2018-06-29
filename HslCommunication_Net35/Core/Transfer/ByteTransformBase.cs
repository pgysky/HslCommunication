﻿using HslCommunication.BasicFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HslCommunication.Core
{
    /// <summary>
    /// 数据转换类的基础，提供了一些基础的方法实现.
    /// </summary>
    public class ByteTransformBase : IByteTransform
    {
        #region Get Value From Bytes

        /// <summary>
        /// 从缓存中提取出bool结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">位的索引</param>
        /// <returns>bool对象</returns>
        public virtual bool TransBool( byte[] buffer, int index )
        {
            return buffer[index] != 0x00;
        }


        /// <summary>
        /// 从缓存中提取出bool数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">位的索引</param>
        /// <param name="length">bool长度</param>
        /// <returns>bool数组</returns>
        public bool[] TransBool( byte[] buffer, int index, int length )
        {
            byte[] tmp = new byte[length];
            Array.Copy( buffer, index, tmp, 0, length );
            return SoftBasic.ByteToBoolArray( tmp, length * 8 );
        }

        /// <summary>
        /// 从缓存中提取byte结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <returns>byte对象</returns>
        public virtual byte TransByte( byte[] buffer, int index )
        {
            return buffer[index];
        }

        /// <summary>
        /// 从缓存中提取byte数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns></returns>
        public virtual byte[] TransByte( byte[] buffer, int index, int length )
        {
            byte[] tmp = new byte[length];
            Array.Copy( buffer, index, tmp, 0, length );
            return tmp;
        }


        /// <summary>
        /// 从缓存中提取short结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <returns>short对象</returns>
        public virtual short TransInt16( byte[] buffer, int index )
        {
            return BitConverter.ToInt16( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取short数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns>short数组对象</returns>
        public virtual short[] TransInt16( byte[] buffer, int index, int length )
        {
            short[] tmp = new short[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransInt16( buffer, index + 2 * i );
            }
            return tmp;
        }


        /// <summary>
        /// 从缓存中提取ushort结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <returns>ushort对象</returns>
        public virtual ushort TransUInt16( byte[] buffer, int index )
        {
            return BitConverter.ToUInt16( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取ushort数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns>ushort数组对象</returns>
        public virtual ushort[] TransUInt16( byte[] buffer, int index, int length )
        {
            ushort[] tmp = new ushort[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransUInt16( buffer, index + 2 * i );
            }
            return tmp;
        }



        /// <summary>
        /// 从缓存中提取int结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <returns>int对象</returns>
        public virtual int TransInt32( byte[] buffer, int index )
        {
            return BitConverter.ToInt32( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取int数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns>int数组对象</returns>
        public virtual int[] TransInt32( byte[] buffer, int index, int length )
        {
            int[] tmp = new int[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransInt32( buffer, index + 4 * i );
            }
            return tmp;
        }



        /// <summary>
        /// 从缓存中提取uint结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <returns>uint对象</returns>
        public virtual uint TransUInt32( byte[] buffer, int index )
        {
            return BitConverter.ToUInt32( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取uint数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns>uint数组对象</returns>
        public virtual uint[] TransUInt32( byte[] buffer, int index, int length )
        {
            uint[] tmp = new uint[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransUInt32( buffer, index + 4 * i );
            }
            return tmp;
        }

        /// <summary>
        /// 从缓存中提取long结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <returns>long对象</returns>
        public virtual long TransInt64( byte[] buffer, int index )
        {
            return BitConverter.ToInt64( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取long数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns>long数组对象</returns>
        public virtual long[] TransInt64( byte[] buffer, int index, int length )
        {
            long[] tmp = new long[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransInt64( buffer, index + 8 * i );
            }
            return tmp;
        }


        /// <summary>
        /// 从缓存中提取ulong结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <returns>ulong对象</returns>
        public virtual ulong TransUInt64( byte[] buffer, int index )
        {
            return BitConverter.ToUInt64( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取ulong数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns>ulong数组对象</returns>
        public virtual ulong[] TransUInt64( byte[] buffer, int index, int length )
        {
            ulong[] tmp = new ulong[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransUInt64( buffer, index + 8 * i );
            }
            return tmp;
        }

        /// <summary>
        /// 从缓存中提取float结果
        /// </summary>
        /// <param name="buffer">缓存对象</param>
        /// <param name="index">索引位置</param>
        /// <returns>float对象</returns>
        public virtual float TransSingle( byte[] buffer, int index )
        {
            return BitConverter.ToSingle( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取float数组结果
        /// </summary>
        /// <param name="buffer">缓存数据</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns></returns>
        public virtual float[] TransSingle( byte[] buffer, int index, int length )
        {
            float[] tmp = new float[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransSingle( buffer, index + 4 * i );
            }
            return tmp;
        }


        /// <summary>
        /// 从缓存中提取double结果
        /// </summary>
        /// <param name="buffer">缓存对象</param>
        /// <param name="index">索引位置</param>
        /// <returns>double对象</returns>
        public virtual double TransDouble( byte[] buffer, int index )
        {
            return BitConverter.ToDouble( buffer, index );
        }

        /// <summary>
        /// 从缓存中提取double数组结果
        /// </summary>
        /// <param name="buffer">缓存对象</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">读取的数组长度</param>
        /// <returns></returns>
        public virtual double[] TransDouble( byte[] buffer, int index, int length )
        {
            double[] tmp = new double[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = TransDouble( buffer, index + 4 * i );
            }
            return tmp;
        }


        /// <summary>
        /// 从缓存中提取string结果，使用指定的编码
        /// </summary>
        /// <param name="buffer">缓存对象</param>
        /// <param name="index">索引位置</param>
        /// <param name="length">byte数组长度</param>
        /// <param name="encoding">字符串的编码</param>
        /// <returns>string对象</returns>
        public virtual string TransString( byte[] buffer, int index, int length, Encoding encoding )
        {
            byte[] tmp = TransByte( buffer, index, length );
            return encoding.GetString( tmp );
        }


        #endregion


        #region Get Bytes From Value


        /// <summary>
        /// bool变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( bool value )
        {
            return TransByte( new bool[] { value } );
        }

        /// <summary>
        /// bool数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( bool[] values )
        {
            if (values == null) return null;

            return BasicFramework.SoftBasic.BoolArrayToByte( values );
        }


        /// <summary>
        /// byte变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( byte value )
        {
            return new byte[] { value };
        }


        /// <summary>
        /// short变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( short value )
        {
            return TransByte( new short[] { value } );
        }


        /// <summary>
        /// short数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( short[] values )
        {
            if (values == null) return null;
            byte[] buffer = new byte[values.Length * 2];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 2 * i );
            }
            return buffer;
        }


        /// <summary>
        /// ushort变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( ushort value )
        {
            return TransByte( new ushort[] { value } );
        }


        /// <summary>
        /// ushort数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( ushort[] values )
        {
            if (values == null) return null;

            byte[] buffer = new byte[values.Length * 2];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 2 * i );
            }

            return buffer;
        }


        /// <summary>
        /// int变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( int value )
        {
            return TransByte( new int[] { value } );
        }


        /// <summary>
        /// int数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( int[] values )
        {
            if (values == null) return null;

            byte[] buffer = new byte[values.Length * 4];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 4 * i );
            }

            return buffer;
        }

        /// <summary>
        /// uint变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( uint value )
        {
            return TransByte( new uint[] { value } );
        }


        /// <summary>
        /// uint数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( uint[] values )
        {
            if (values == null) return null;

            byte[] buffer = new byte[values.Length * 4];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 4 * i );
            }

            return buffer;
        }


        /// <summary>
        /// long变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( long value )
        {
            return TransByte( new long[] { value } );
        }

        /// <summary>
        /// long数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( long[] values )
        {
            if (values == null) return null;

            byte[] buffer = new byte[values.Length * 8];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 8 * i );
            }

            return buffer;
        }

        /// <summary>
        /// ulong变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( ulong value )
        {
            return TransByte( new ulong[] { value } );
        }

        /// <summary>
        /// ulong数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( ulong[] values )
        {
            if (values == null) return null;

            byte[] buffer = new byte[values.Length * 8];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 8 * i );
            }

            return buffer;
        }

        /// <summary>
        /// float变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( float value )
        {
            return TransByte( new float[] { value } );
        }

        /// <summary>
        /// float数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( float[] values )
        {
            if (values == null) return null;

            byte[] buffer = new byte[values.Length * 4];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 4 * i );
            }

            return buffer;
        }

        /// <summary>
        /// double变量转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( double value )
        {
            return TransByte( new double[] { value } );
        }

        /// <summary>
        /// double数组变量转化缓存数据
        /// </summary>
        /// <param name="values">等待转化的数组</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( double[] values )
        {
            if (values == null) return null;

            byte[] buffer = new byte[values.Length * 8];
            for (int i = 0; i < values.Length; i++)
            {
                BitConverter.GetBytes( values[i] ).CopyTo( buffer, 8 * i );
            }

            return buffer;
        }

        /// <summary>
        /// 使用指定的编码字符串转化缓存数据
        /// </summary>
        /// <param name="value">等待转化的数据</param>
        /// <param name="encoding">字符串的编码方式</param>
        /// <returns>buffer数据</returns>
        public virtual byte[] TransByte( string value, Encoding encoding )
        {
            if (value == null) return null;

            return encoding.GetBytes( value );
        }


        #endregion

    }
    
}
