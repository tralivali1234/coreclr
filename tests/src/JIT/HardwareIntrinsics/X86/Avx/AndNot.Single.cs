// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/******************************************************************************
 * This file is auto-generated from a template file by the GenerateTests.csx  *
 * script in tests\src\JIT\HardwareIntrinsics\X86\Shared. In order to make    *
 * changes, please update the corresponding template and run according to the *
 * directions listed in the file.                                             *
 ******************************************************************************/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace JIT.HardwareIntrinsics.X86
{
    public static partial class Program
    {
        private static void AndNotSingle()
        {
            var test = new SimpleBinaryOpTest__AndNotSingle();

            if (test.IsSupported)
            {
                // Validates basic functionality works, using Unsafe.Read
                test.RunBasicScenario_UnsafeRead();

                // Validates basic functionality works, using Load
                test.RunBasicScenario_Load();

                // Validates basic functionality works, using LoadAligned
                test.RunBasicScenario_LoadAligned();

                // Validates calling via reflection works, using Unsafe.Read
                test.RunReflectionScenario_UnsafeRead();

                // Validates calling via reflection works, using Load
                test.RunReflectionScenario_Load();

                // Validates calling via reflection works, using LoadAligned
                test.RunReflectionScenario_LoadAligned();

                // Validates passing a static member works
                test.RunClsVarScenario();

                // Validates passing a local works, using Unsafe.Read
                test.RunLclVarScenario_UnsafeRead();

                // Validates passing a local works, using Load
                test.RunLclVarScenario_Load();

                // Validates passing a local works, using LoadAligned
                test.RunLclVarScenario_LoadAligned();

                // Validates passing the field of a local works
                test.RunLclFldScenario();

                // Validates passing an instance member works
                test.RunFldScenario();
            }
            else
            {
                // Validates we throw on unsupported hardware
                test.RunUnsupportedScenario();
            }

            if (!test.Succeeded)
            {
                throw new Exception("One or more scenarios did not complete as expected.");
            }
        }
    }

    public sealed unsafe class SimpleBinaryOpTest__AndNotSingle
    {
        private const int VectorSize = 32;
        private const int ElementCount = VectorSize / sizeof(Single);

        private static Single[] _data1 = new Single[ElementCount];
        private static Single[] _data2 = new Single[ElementCount];

        private static Vector256<Single> _clsVar1;
        private static Vector256<Single> _clsVar2;

        private Vector256<Single> _fld1;
        private Vector256<Single> _fld2;

        private SimpleBinaryOpTest__DataTable<Single> _dataTable;

        static SimpleBinaryOpTest__AndNotSingle()
        {
            var random = new Random();

            for (var i = 0; i < ElementCount; i++) { _data1[i] = (float)(random.NextDouble()); _data2[i] = (float)(random.NextDouble()); }
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector256<Single>, byte>(ref _clsVar1), ref Unsafe.As<Single, byte>(ref _data2[0]), VectorSize);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector256<Single>, byte>(ref _clsVar2), ref Unsafe.As<Single, byte>(ref _data1[0]), VectorSize);
        }

        public SimpleBinaryOpTest__AndNotSingle()
        {
            Succeeded = true;

            var random = new Random();

            for (var i = 0; i < ElementCount; i++) { _data1[i] = (float)(random.NextDouble()); _data2[i] = (float)(random.NextDouble()); }
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector256<Single>, byte>(ref _fld1), ref Unsafe.As<Single, byte>(ref _data1[0]), VectorSize);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector256<Single>, byte>(ref _fld2), ref Unsafe.As<Single, byte>(ref _data2[0]), VectorSize);

            for (var i = 0; i < ElementCount; i++) { _data1[i] = (float)(random.NextDouble()); _data2[i] = (float)(random.NextDouble()); }
            _dataTable = new SimpleBinaryOpTest__DataTable<Single>(_data1, _data2, new Single[ElementCount], VectorSize);
        }

        public bool IsSupported => Avx.IsSupported;

        public bool Succeeded { get; set; }

        public void RunBasicScenario_UnsafeRead()
        {
            var result = Avx.AndNot(
                Unsafe.Read<Vector256<Single>>(_dataTable.inArray1Ptr),
                Unsafe.Read<Vector256<Single>>(_dataTable.inArray2Ptr)
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArray1Ptr, _dataTable.inArray2Ptr, _dataTable.outArrayPtr);
        }

        public void RunBasicScenario_Load()
        {
            var result = Avx.AndNot(
                Avx.LoadVector256((Single*)(_dataTable.inArray1Ptr)),
                Avx.LoadVector256((Single*)(_dataTable.inArray2Ptr))
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArray1Ptr, _dataTable.inArray2Ptr, _dataTable.outArrayPtr);
        }

        public void RunBasicScenario_LoadAligned()
        {
            var result = Avx.AndNot(
                Avx.LoadAlignedVector256((Single*)(_dataTable.inArray1Ptr)),
                Avx.LoadAlignedVector256((Single*)(_dataTable.inArray2Ptr))
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArray1Ptr, _dataTable.inArray2Ptr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_UnsafeRead()
        {
            var result = typeof(Avx).GetMethod(nameof(Avx.AndNot), new Type[] { typeof(Vector256<Single>), typeof(Vector256<Single>) })
                                     .Invoke(null, new object[] {
                                        Unsafe.Read<Vector256<Single>>(_dataTable.inArray1Ptr),
                                        Unsafe.Read<Vector256<Single>>(_dataTable.inArray2Ptr)
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<Single>)(result));
            ValidateResult(_dataTable.inArray1Ptr, _dataTable.inArray2Ptr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_Load()
        {
            var result = typeof(Avx).GetMethod(nameof(Avx.AndNot), new Type[] { typeof(Vector256<Single>), typeof(Vector256<Single>) })
                                     .Invoke(null, new object[] {
                                        Avx.LoadVector256((Single*)(_dataTable.inArray1Ptr)),
                                        Avx.LoadVector256((Single*)(_dataTable.inArray2Ptr))
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<Single>)(result));
            ValidateResult(_dataTable.inArray1Ptr, _dataTable.inArray2Ptr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_LoadAligned()
        {
            var result = typeof(Avx).GetMethod(nameof(Avx.AndNot), new Type[] { typeof(Vector256<Single>), typeof(Vector256<Single>) })
                                     .Invoke(null, new object[] {
                                        Avx.LoadAlignedVector256((Single*)(_dataTable.inArray1Ptr)),
                                        Avx.LoadAlignedVector256((Single*)(_dataTable.inArray2Ptr))
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<Single>)(result));
            ValidateResult(_dataTable.inArray1Ptr, _dataTable.inArray2Ptr, _dataTable.outArrayPtr);
        }

        public void RunClsVarScenario()
        {
            var result = Avx.AndNot(
                _clsVar1,
                _clsVar2
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_clsVar1, _clsVar2, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_UnsafeRead()
        {
            var left = Unsafe.Read<Vector256<Single>>(_dataTable.inArray1Ptr);
            var right = Unsafe.Read<Vector256<Single>>(_dataTable.inArray2Ptr);
            var result = Avx.AndNot(left, right);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(left, right, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_Load()
        {
            var left = Avx.LoadVector256((Single*)(_dataTable.inArray1Ptr));
            var right = Avx.LoadVector256((Single*)(_dataTable.inArray2Ptr));
            var result = Avx.AndNot(left, right);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(left, right, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_LoadAligned()
        {
            var left = Avx.LoadAlignedVector256((Single*)(_dataTable.inArray1Ptr));
            var right = Avx.LoadAlignedVector256((Single*)(_dataTable.inArray2Ptr));
            var result = Avx.AndNot(left, right);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(left, right, _dataTable.outArrayPtr);
        }

        public void RunLclFldScenario()
        {
            var test = new SimpleBinaryOpTest__AndNotSingle();
            var result = Avx.AndNot(test._fld1, test._fld2);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(test._fld1, test._fld2, _dataTable.outArrayPtr);
        }

        public void RunFldScenario()
        {
            var result = Avx.AndNot(_fld1, _fld2);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_fld1, _fld2, _dataTable.outArrayPtr);
        }

        public void RunUnsupportedScenario()
        {
            Succeeded = false;

            try
            {
                RunBasicScenario_UnsafeRead();
            }
            catch (PlatformNotSupportedException)
            {
                Succeeded = true;
            }
        }

        private void ValidateResult(Vector256<Single> left, Vector256<Single> right, void* result, [CallerMemberName] string method = "")
        {
            Single[] inArray1 = new Single[ElementCount];
            Single[] inArray2 = new Single[ElementCount];
            Single[] outArray = new Single[ElementCount];

            Unsafe.Write(Unsafe.AsPointer(ref inArray1[0]), left);
            Unsafe.Write(Unsafe.AsPointer(ref inArray2[0]), right);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Single, byte>(ref outArray[0]), ref Unsafe.AsRef<byte>(result), VectorSize);

            ValidateResult(inArray1, inArray2, outArray, method);
        }

        private void ValidateResult(void* left, void* right, void* result, [CallerMemberName] string method = "")
        {
            Single[] inArray1 = new Single[ElementCount];
            Single[] inArray2 = new Single[ElementCount];
            Single[] outArray = new Single[ElementCount];

            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Single, byte>(ref inArray1[0]), ref Unsafe.AsRef<byte>(left), VectorSize);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Single, byte>(ref inArray2[0]), ref Unsafe.AsRef<byte>(right), VectorSize);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Single, byte>(ref outArray[0]), ref Unsafe.AsRef<byte>(result), VectorSize);

            ValidateResult(inArray1, inArray2, outArray, method);
        }

        private void ValidateResult(Single[] left, Single[] right, Single[] result, [CallerMemberName] string method = "")
        {
            if (((~BitConverter.SingleToInt32Bits(left[0])) & BitConverter.SingleToInt32Bits(right[0])) != BitConverter.SingleToInt32Bits(result[0]))
            {
                Succeeded = false;
            }
            else
            {
                for (var i = 1; i < left.Length; i++)
                {
                    if (((~BitConverter.SingleToInt32Bits(left[i])) & BitConverter.SingleToInt32Bits(right[i])) != BitConverter.SingleToInt32Bits(result[i]))
                    {
                        Succeeded = false;
                        break;
                    }
                }
            }

            if (!Succeeded)
            {
                Console.WriteLine($"{nameof(Avx)}.{nameof(Avx.AndNot)}<Single>: {method} failed:");
                Console.WriteLine($"    left: ({string.Join(", ", left)})");
                Console.WriteLine($"   right: ({string.Join(", ", right)})");
                Console.WriteLine($"  result: ({string.Join(", ", result)})");
                Console.WriteLine();
            }
        }
    }
}
