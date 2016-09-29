// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#pragma warning disable 0184


using System;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Eval(int testCase, bool b1, bool b2)
    {
        if (b1 != b2) throw new Exception(string.Format("case {0:000} failed: v1 {1} v2 {2}", testCase, b1, b2));
    }

    private static void TestCase0001()
    {
        {
            IntE v = default(IntE);
            Enum o = v;
            Eval(0001, o is IntE, true);
            Eval(0002, o is IntE[], false);
            Eval(0003, o is IntE?, true);
            Eval(0004, o is IntE?[], false);
            Eval(0005, o is ByteE, false);
            Eval(0006, o is ByteE[], false);
            Eval(0007, o is ByteE?, false);
            Eval(0008, o is ByteE?[], false);
            Eval(0009, o is LongE, false);
            Eval(0010, o is LongE[], false);
            Eval(0011, o is LongE?, false);
            Eval(0012, o is LongE?[], false);
            Eval(0013, o is object, true);
            Eval(0014, o is object[], false);
            Eval(0015, o is string, false);
            Eval(0016, o is string[], false);
            Eval(0017, o is ValueType, true);
            Eval(0018, o is ValueType[], false);
            Eval(0019, o is Array, false);
            Eval(0020, o is Array[], false);
            Eval(0021, o is Enum, true);
            Eval(0022, o is Enum[], false);
            Eval(0023, o is Delegate, false);
            Eval(0024, o is Delegate[], false);
            Eval(0025, o is MulticastDelegate, false);
            Eval(0026, o is MulticastDelegate[], false);
            Eval(0027, o is IEmpty, false);
            Eval(0028, o is IEmpty[], false);
            Eval(0029, o is INotEmpty, false);
            Eval(0030, o is INotEmpty[], false);
            Eval(0031, o is IEmptyGen<int>, false);
            Eval(0032, o is IEmptyGen<int>[], false);
            Eval(0033, o is INotEmptyGen<int>, false);
            Eval(0034, o is INotEmptyGen<int>[], false);
            Eval(0035, o is SimpleDelegate, false);
            Eval(0036, o is SimpleDelegate[], false);
            Eval(0037, o is GenericDelegate<int>, false);
            Eval(0038, o is GenericDelegate<int>[], false);
            Eval(0039, o is EmptyClass, false);
            Eval(0040, o is EmptyClass[], false);
            Eval(0041, o is NotEmptyClass, false);
            Eval(0042, o is NotEmptyClass[], false);
            Eval(0043, o is EmptyClassGen<int>, false);
            Eval(0044, o is EmptyClassGen<int>[], false);
            Eval(0045, o is NotEmptyClassGen<Guid>, false);
            Eval(0046, o is NotEmptyClassGen<Guid>[], false);
            Eval(0047, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0048, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0049, o is NestedClass, false);
            Eval(0050, o is NestedClass[], false);
            Eval(0051, o is NestedClassGen<Decimal>, false);
            Eval(0052, o is NestedClassGen<Decimal>[], false);
            Eval(0053, o is ImplementOneInterfaceC, false);
            Eval(0054, o is ImplementOneInterfaceC[], false);
            Eval(0055, o is ImplementTwoInterfaceC, false);
            Eval(0056, o is ImplementTwoInterfaceC[], false);
            Eval(0057, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0058, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0059, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0060, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0061, o is ImplementAllInterfaceC<int>, false);
            Eval(0062, o is ImplementAllInterfaceC<int>[], false);
            Eval(0063, o is SealedClass, false);
            Eval(0064, o is SealedClass[], false);
        }
        {
            IntE? v = default(IntE);
            Enum o = v;
            Eval(0065, o is IntE, true);
            Eval(0066, o is IntE[], false);
            Eval(0067, o is IntE?, true);
            Eval(0068, o is IntE?[], false);
            Eval(0069, o is ByteE, false);
            Eval(0070, o is ByteE[], false);
            Eval(0071, o is ByteE?, false);
            Eval(0072, o is ByteE?[], false);
            Eval(0073, o is LongE, false);
            Eval(0074, o is LongE[], false);
            Eval(0075, o is LongE?, false);
            Eval(0076, o is LongE?[], false);
            Eval(0077, o is object, true);
            Eval(0078, o is object[], false);
            Eval(0079, o is string, false);
            Eval(0080, o is string[], false);
            Eval(0081, o is ValueType, true);
            Eval(0082, o is ValueType[], false);
            Eval(0083, o is Array, false);
            Eval(0084, o is Array[], false);
            Eval(0085, o is Enum, true);
            Eval(0086, o is Enum[], false);
            Eval(0087, o is Delegate, false);
            Eval(0088, o is Delegate[], false);
            Eval(0089, o is MulticastDelegate, false);
            Eval(0090, o is MulticastDelegate[], false);
            Eval(0091, o is IEmpty, false);
            Eval(0092, o is IEmpty[], false);
            Eval(0093, o is INotEmpty, false);
            Eval(0094, o is INotEmpty[], false);
            Eval(0095, o is IEmptyGen<int>, false);
            Eval(0096, o is IEmptyGen<int>[], false);
            Eval(0097, o is INotEmptyGen<int>, false);
            Eval(0098, o is INotEmptyGen<int>[], false);
            Eval(0099, o is SimpleDelegate, false);
            Eval(0100, o is SimpleDelegate[], false);
            Eval(0101, o is GenericDelegate<int>, false);
            Eval(0102, o is GenericDelegate<int>[], false);
            Eval(0103, o is EmptyClass, false);
            Eval(0104, o is EmptyClass[], false);
            Eval(0105, o is NotEmptyClass, false);
            Eval(0106, o is NotEmptyClass[], false);
            Eval(0107, o is EmptyClassGen<int>, false);
            Eval(0108, o is EmptyClassGen<int>[], false);
            Eval(0109, o is NotEmptyClassGen<Guid>, false);
            Eval(0110, o is NotEmptyClassGen<Guid>[], false);
            Eval(0111, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0112, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0113, o is NestedClass, false);
            Eval(0114, o is NestedClass[], false);
            Eval(0115, o is NestedClassGen<Decimal>, false);
            Eval(0116, o is NestedClassGen<Decimal>[], false);
            Eval(0117, o is ImplementOneInterfaceC, false);
            Eval(0118, o is ImplementOneInterfaceC[], false);
            Eval(0119, o is ImplementTwoInterfaceC, false);
            Eval(0120, o is ImplementTwoInterfaceC[], false);
            Eval(0121, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0122, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0123, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0124, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0125, o is ImplementAllInterfaceC<int>, false);
            Eval(0126, o is ImplementAllInterfaceC<int>[], false);
            Eval(0127, o is SealedClass, false);
            Eval(0128, o is SealedClass[], false);
        }
        {
            IntE? v = default(IntE?);
            Enum o = v;
            Eval(0129, o is IntE, false);
            Eval(0130, o is IntE[], false);
            Eval(0131, o is IntE?, false);
            Eval(0132, o is IntE?[], false);
            Eval(0133, o is ByteE, false);
            Eval(0134, o is ByteE[], false);
            Eval(0135, o is ByteE?, false);
            Eval(0136, o is ByteE?[], false);
            Eval(0137, o is LongE, false);
            Eval(0138, o is LongE[], false);
            Eval(0139, o is LongE?, false);
            Eval(0140, o is LongE?[], false);
            Eval(0141, o is object, false);
            Eval(0142, o is object[], false);
            Eval(0143, o is string, false);
            Eval(0144, o is string[], false);
            Eval(0145, o is ValueType, false);
            Eval(0146, o is ValueType[], false);
            Eval(0147, o is Array, false);
            Eval(0148, o is Array[], false);
            Eval(0149, o is Enum, false);
            Eval(0150, o is Enum[], false);
            Eval(0151, o is Delegate, false);
            Eval(0152, o is Delegate[], false);
            Eval(0153, o is MulticastDelegate, false);
            Eval(0154, o is MulticastDelegate[], false);
            Eval(0155, o is IEmpty, false);
            Eval(0156, o is IEmpty[], false);
            Eval(0157, o is INotEmpty, false);
            Eval(0158, o is INotEmpty[], false);
            Eval(0159, o is IEmptyGen<int>, false);
            Eval(0160, o is IEmptyGen<int>[], false);
            Eval(0161, o is INotEmptyGen<int>, false);
            Eval(0162, o is INotEmptyGen<int>[], false);
            Eval(0163, o is SimpleDelegate, false);
            Eval(0164, o is SimpleDelegate[], false);
            Eval(0165, o is GenericDelegate<int>, false);
            Eval(0166, o is GenericDelegate<int>[], false);
            Eval(0167, o is EmptyClass, false);
            Eval(0168, o is EmptyClass[], false);
            Eval(0169, o is NotEmptyClass, false);
            Eval(0170, o is NotEmptyClass[], false);
            Eval(0171, o is EmptyClassGen<int>, false);
            Eval(0172, o is EmptyClassGen<int>[], false);
            Eval(0173, o is NotEmptyClassGen<Guid>, false);
            Eval(0174, o is NotEmptyClassGen<Guid>[], false);
            Eval(0175, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0176, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0177, o is NestedClass, false);
            Eval(0178, o is NestedClass[], false);
            Eval(0179, o is NestedClassGen<Decimal>, false);
            Eval(0180, o is NestedClassGen<Decimal>[], false);
            Eval(0181, o is ImplementOneInterfaceC, false);
            Eval(0182, o is ImplementOneInterfaceC[], false);
            Eval(0183, o is ImplementTwoInterfaceC, false);
            Eval(0184, o is ImplementTwoInterfaceC[], false);
            Eval(0185, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0186, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0187, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0188, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0189, o is ImplementAllInterfaceC<int>, false);
            Eval(0190, o is ImplementAllInterfaceC<int>[], false);
            Eval(0191, o is SealedClass, false);
            Eval(0192, o is SealedClass[], false);
        }
    }  // end of test case 0001
    private static void TestCase0002()
    {
        {
            ByteE v = default(ByteE);
            Enum o = v;
            Eval(0193, o is IntE, false);
            Eval(0194, o is IntE[], false);
            Eval(0195, o is IntE?, false);
            Eval(0196, o is IntE?[], false);
            Eval(0197, o is ByteE, true);
            Eval(0198, o is ByteE[], false);
            Eval(0199, o is ByteE?, true);
            Eval(0200, o is ByteE?[], false);
            Eval(0201, o is LongE, false);
            Eval(0202, o is LongE[], false);
            Eval(0203, o is LongE?, false);
            Eval(0204, o is LongE?[], false);
            Eval(0205, o is object, true);
            Eval(0206, o is object[], false);
            Eval(0207, o is string, false);
            Eval(0208, o is string[], false);
            Eval(0209, o is ValueType, true);
            Eval(0210, o is ValueType[], false);
            Eval(0211, o is Array, false);
            Eval(0212, o is Array[], false);
            Eval(0213, o is Enum, true);
            Eval(0214, o is Enum[], false);
            Eval(0215, o is Delegate, false);
            Eval(0216, o is Delegate[], false);
            Eval(0217, o is MulticastDelegate, false);
            Eval(0218, o is MulticastDelegate[], false);
            Eval(0219, o is IEmpty, false);
            Eval(0220, o is IEmpty[], false);
            Eval(0221, o is INotEmpty, false);
            Eval(0222, o is INotEmpty[], false);
            Eval(0223, o is IEmptyGen<int>, false);
            Eval(0224, o is IEmptyGen<int>[], false);
            Eval(0225, o is INotEmptyGen<int>, false);
            Eval(0226, o is INotEmptyGen<int>[], false);
            Eval(0227, o is SimpleDelegate, false);
            Eval(0228, o is SimpleDelegate[], false);
            Eval(0229, o is GenericDelegate<int>, false);
            Eval(0230, o is GenericDelegate<int>[], false);
            Eval(0231, o is EmptyClass, false);
            Eval(0232, o is EmptyClass[], false);
            Eval(0233, o is NotEmptyClass, false);
            Eval(0234, o is NotEmptyClass[], false);
            Eval(0235, o is EmptyClassGen<int>, false);
            Eval(0236, o is EmptyClassGen<int>[], false);
            Eval(0237, o is NotEmptyClassGen<Guid>, false);
            Eval(0238, o is NotEmptyClassGen<Guid>[], false);
            Eval(0239, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0240, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0241, o is NestedClass, false);
            Eval(0242, o is NestedClass[], false);
            Eval(0243, o is NestedClassGen<Decimal>, false);
            Eval(0244, o is NestedClassGen<Decimal>[], false);
            Eval(0245, o is ImplementOneInterfaceC, false);
            Eval(0246, o is ImplementOneInterfaceC[], false);
            Eval(0247, o is ImplementTwoInterfaceC, false);
            Eval(0248, o is ImplementTwoInterfaceC[], false);
            Eval(0249, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0250, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0251, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0252, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0253, o is ImplementAllInterfaceC<int>, false);
            Eval(0254, o is ImplementAllInterfaceC<int>[], false);
            Eval(0255, o is SealedClass, false);
            Eval(0256, o is SealedClass[], false);
        }
        {
            ByteE? v = default(ByteE);
            Enum o = v;
            Eval(0257, o is IntE, false);
            Eval(0258, o is IntE[], false);
            Eval(0259, o is IntE?, false);
            Eval(0260, o is IntE?[], false);
            Eval(0261, o is ByteE, true);
            Eval(0262, o is ByteE[], false);
            Eval(0263, o is ByteE?, true);
            Eval(0264, o is ByteE?[], false);
            Eval(0265, o is LongE, false);
            Eval(0266, o is LongE[], false);
            Eval(0267, o is LongE?, false);
            Eval(0268, o is LongE?[], false);
            Eval(0269, o is object, true);
            Eval(0270, o is object[], false);
            Eval(0271, o is string, false);
            Eval(0272, o is string[], false);
            Eval(0273, o is ValueType, true);
            Eval(0274, o is ValueType[], false);
            Eval(0275, o is Array, false);
            Eval(0276, o is Array[], false);
            Eval(0277, o is Enum, true);
            Eval(0278, o is Enum[], false);
            Eval(0279, o is Delegate, false);
            Eval(0280, o is Delegate[], false);
            Eval(0281, o is MulticastDelegate, false);
            Eval(0282, o is MulticastDelegate[], false);
            Eval(0283, o is IEmpty, false);
            Eval(0284, o is IEmpty[], false);
            Eval(0285, o is INotEmpty, false);
            Eval(0286, o is INotEmpty[], false);
            Eval(0287, o is IEmptyGen<int>, false);
            Eval(0288, o is IEmptyGen<int>[], false);
            Eval(0289, o is INotEmptyGen<int>, false);
            Eval(0290, o is INotEmptyGen<int>[], false);
            Eval(0291, o is SimpleDelegate, false);
            Eval(0292, o is SimpleDelegate[], false);
            Eval(0293, o is GenericDelegate<int>, false);
            Eval(0294, o is GenericDelegate<int>[], false);
            Eval(0295, o is EmptyClass, false);
            Eval(0296, o is EmptyClass[], false);
            Eval(0297, o is NotEmptyClass, false);
            Eval(0298, o is NotEmptyClass[], false);
            Eval(0299, o is EmptyClassGen<int>, false);
            Eval(0300, o is EmptyClassGen<int>[], false);
            Eval(0301, o is NotEmptyClassGen<Guid>, false);
            Eval(0302, o is NotEmptyClassGen<Guid>[], false);
            Eval(0303, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0304, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0305, o is NestedClass, false);
            Eval(0306, o is NestedClass[], false);
            Eval(0307, o is NestedClassGen<Decimal>, false);
            Eval(0308, o is NestedClassGen<Decimal>[], false);
            Eval(0309, o is ImplementOneInterfaceC, false);
            Eval(0310, o is ImplementOneInterfaceC[], false);
            Eval(0311, o is ImplementTwoInterfaceC, false);
            Eval(0312, o is ImplementTwoInterfaceC[], false);
            Eval(0313, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0314, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0315, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0316, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0317, o is ImplementAllInterfaceC<int>, false);
            Eval(0318, o is ImplementAllInterfaceC<int>[], false);
            Eval(0319, o is SealedClass, false);
            Eval(0320, o is SealedClass[], false);
        }
        {
            ByteE? v = default(ByteE?);
            Enum o = v;
            Eval(0321, o is IntE, false);
            Eval(0322, o is IntE[], false);
            Eval(0323, o is IntE?, false);
            Eval(0324, o is IntE?[], false);
            Eval(0325, o is ByteE, false);
            Eval(0326, o is ByteE[], false);
            Eval(0327, o is ByteE?, false);
            Eval(0328, o is ByteE?[], false);
            Eval(0329, o is LongE, false);
            Eval(0330, o is LongE[], false);
            Eval(0331, o is LongE?, false);
            Eval(0332, o is LongE?[], false);
            Eval(0333, o is object, false);
            Eval(0334, o is object[], false);
            Eval(0335, o is string, false);
            Eval(0336, o is string[], false);
            Eval(0337, o is ValueType, false);
            Eval(0338, o is ValueType[], false);
            Eval(0339, o is Array, false);
            Eval(0340, o is Array[], false);
            Eval(0341, o is Enum, false);
            Eval(0342, o is Enum[], false);
            Eval(0343, o is Delegate, false);
            Eval(0344, o is Delegate[], false);
            Eval(0345, o is MulticastDelegate, false);
            Eval(0346, o is MulticastDelegate[], false);
            Eval(0347, o is IEmpty, false);
            Eval(0348, o is IEmpty[], false);
            Eval(0349, o is INotEmpty, false);
            Eval(0350, o is INotEmpty[], false);
            Eval(0351, o is IEmptyGen<int>, false);
            Eval(0352, o is IEmptyGen<int>[], false);
            Eval(0353, o is INotEmptyGen<int>, false);
            Eval(0354, o is INotEmptyGen<int>[], false);
            Eval(0355, o is SimpleDelegate, false);
            Eval(0356, o is SimpleDelegate[], false);
            Eval(0357, o is GenericDelegate<int>, false);
            Eval(0358, o is GenericDelegate<int>[], false);
            Eval(0359, o is EmptyClass, false);
            Eval(0360, o is EmptyClass[], false);
            Eval(0361, o is NotEmptyClass, false);
            Eval(0362, o is NotEmptyClass[], false);
            Eval(0363, o is EmptyClassGen<int>, false);
            Eval(0364, o is EmptyClassGen<int>[], false);
            Eval(0365, o is NotEmptyClassGen<Guid>, false);
            Eval(0366, o is NotEmptyClassGen<Guid>[], false);
            Eval(0367, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0368, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0369, o is NestedClass, false);
            Eval(0370, o is NestedClass[], false);
            Eval(0371, o is NestedClassGen<Decimal>, false);
            Eval(0372, o is NestedClassGen<Decimal>[], false);
            Eval(0373, o is ImplementOneInterfaceC, false);
            Eval(0374, o is ImplementOneInterfaceC[], false);
            Eval(0375, o is ImplementTwoInterfaceC, false);
            Eval(0376, o is ImplementTwoInterfaceC[], false);
            Eval(0377, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0378, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0379, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0380, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0381, o is ImplementAllInterfaceC<int>, false);
            Eval(0382, o is ImplementAllInterfaceC<int>[], false);
            Eval(0383, o is SealedClass, false);
            Eval(0384, o is SealedClass[], false);
        }
    }  // end of test case 0002
    private static void TestCase0003()
    {
        {
            LongE v = default(LongE);
            Enum o = v;
            Eval(0385, o is IntE, false);
            Eval(0386, o is IntE[], false);
            Eval(0387, o is IntE?, false);
            Eval(0388, o is IntE?[], false);
            Eval(0389, o is ByteE, false);
            Eval(0390, o is ByteE[], false);
            Eval(0391, o is ByteE?, false);
            Eval(0392, o is ByteE?[], false);
            Eval(0393, o is LongE, true);
            Eval(0394, o is LongE[], false);
            Eval(0395, o is LongE?, true);
            Eval(0396, o is LongE?[], false);
            Eval(0397, o is object, true);
            Eval(0398, o is object[], false);
            Eval(0399, o is string, false);
            Eval(0400, o is string[], false);
            Eval(0401, o is ValueType, true);
            Eval(0402, o is ValueType[], false);
            Eval(0403, o is Array, false);
            Eval(0404, o is Array[], false);
            Eval(0405, o is Enum, true);
            Eval(0406, o is Enum[], false);
            Eval(0407, o is Delegate, false);
            Eval(0408, o is Delegate[], false);
            Eval(0409, o is MulticastDelegate, false);
            Eval(0410, o is MulticastDelegate[], false);
            Eval(0411, o is IEmpty, false);
            Eval(0412, o is IEmpty[], false);
            Eval(0413, o is INotEmpty, false);
            Eval(0414, o is INotEmpty[], false);
            Eval(0415, o is IEmptyGen<int>, false);
            Eval(0416, o is IEmptyGen<int>[], false);
            Eval(0417, o is INotEmptyGen<int>, false);
            Eval(0418, o is INotEmptyGen<int>[], false);
            Eval(0419, o is SimpleDelegate, false);
            Eval(0420, o is SimpleDelegate[], false);
            Eval(0421, o is GenericDelegate<int>, false);
            Eval(0422, o is GenericDelegate<int>[], false);
            Eval(0423, o is EmptyClass, false);
            Eval(0424, o is EmptyClass[], false);
            Eval(0425, o is NotEmptyClass, false);
            Eval(0426, o is NotEmptyClass[], false);
            Eval(0427, o is EmptyClassGen<int>, false);
            Eval(0428, o is EmptyClassGen<int>[], false);
            Eval(0429, o is NotEmptyClassGen<Guid>, false);
            Eval(0430, o is NotEmptyClassGen<Guid>[], false);
            Eval(0431, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0432, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0433, o is NestedClass, false);
            Eval(0434, o is NestedClass[], false);
            Eval(0435, o is NestedClassGen<Decimal>, false);
            Eval(0436, o is NestedClassGen<Decimal>[], false);
            Eval(0437, o is ImplementOneInterfaceC, false);
            Eval(0438, o is ImplementOneInterfaceC[], false);
            Eval(0439, o is ImplementTwoInterfaceC, false);
            Eval(0440, o is ImplementTwoInterfaceC[], false);
            Eval(0441, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0442, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0443, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0444, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0445, o is ImplementAllInterfaceC<int>, false);
            Eval(0446, o is ImplementAllInterfaceC<int>[], false);
            Eval(0447, o is SealedClass, false);
            Eval(0448, o is SealedClass[], false);
        }
        {
            LongE? v = default(LongE);
            Enum o = v;
            Eval(0449, o is IntE, false);
            Eval(0450, o is IntE[], false);
            Eval(0451, o is IntE?, false);
            Eval(0452, o is IntE?[], false);
            Eval(0453, o is ByteE, false);
            Eval(0454, o is ByteE[], false);
            Eval(0455, o is ByteE?, false);
            Eval(0456, o is ByteE?[], false);
            Eval(0457, o is LongE, true);
            Eval(0458, o is LongE[], false);
            Eval(0459, o is LongE?, true);
            Eval(0460, o is LongE?[], false);
            Eval(0461, o is object, true);
            Eval(0462, o is object[], false);
            Eval(0463, o is string, false);
            Eval(0464, o is string[], false);
            Eval(0465, o is ValueType, true);
            Eval(0466, o is ValueType[], false);
            Eval(0467, o is Array, false);
            Eval(0468, o is Array[], false);
            Eval(0469, o is Enum, true);
            Eval(0470, o is Enum[], false);
            Eval(0471, o is Delegate, false);
            Eval(0472, o is Delegate[], false);
            Eval(0473, o is MulticastDelegate, false);
            Eval(0474, o is MulticastDelegate[], false);
            Eval(0475, o is IEmpty, false);
            Eval(0476, o is IEmpty[], false);
            Eval(0477, o is INotEmpty, false);
            Eval(0478, o is INotEmpty[], false);
            Eval(0479, o is IEmptyGen<int>, false);
            Eval(0480, o is IEmptyGen<int>[], false);
            Eval(0481, o is INotEmptyGen<int>, false);
            Eval(0482, o is INotEmptyGen<int>[], false);
            Eval(0483, o is SimpleDelegate, false);
            Eval(0484, o is SimpleDelegate[], false);
            Eval(0485, o is GenericDelegate<int>, false);
            Eval(0486, o is GenericDelegate<int>[], false);
            Eval(0487, o is EmptyClass, false);
            Eval(0488, o is EmptyClass[], false);
            Eval(0489, o is NotEmptyClass, false);
            Eval(0490, o is NotEmptyClass[], false);
            Eval(0491, o is EmptyClassGen<int>, false);
            Eval(0492, o is EmptyClassGen<int>[], false);
            Eval(0493, o is NotEmptyClassGen<Guid>, false);
            Eval(0494, o is NotEmptyClassGen<Guid>[], false);
            Eval(0495, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0496, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0497, o is NestedClass, false);
            Eval(0498, o is NestedClass[], false);
            Eval(0499, o is NestedClassGen<Decimal>, false);
            Eval(0500, o is NestedClassGen<Decimal>[], false);
            Eval(0501, o is ImplementOneInterfaceC, false);
            Eval(0502, o is ImplementOneInterfaceC[], false);
            Eval(0503, o is ImplementTwoInterfaceC, false);
            Eval(0504, o is ImplementTwoInterfaceC[], false);
            Eval(0505, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0506, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0507, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0508, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0509, o is ImplementAllInterfaceC<int>, false);
            Eval(0510, o is ImplementAllInterfaceC<int>[], false);
            Eval(0511, o is SealedClass, false);
            Eval(0512, o is SealedClass[], false);
        }
        {
            LongE? v = default(LongE?);
            Enum o = v;
            Eval(0513, o is IntE, false);
            Eval(0514, o is IntE[], false);
            Eval(0515, o is IntE?, false);
            Eval(0516, o is IntE?[], false);
            Eval(0517, o is ByteE, false);
            Eval(0518, o is ByteE[], false);
            Eval(0519, o is ByteE?, false);
            Eval(0520, o is ByteE?[], false);
            Eval(0521, o is LongE, false);
            Eval(0522, o is LongE[], false);
            Eval(0523, o is LongE?, false);
            Eval(0524, o is LongE?[], false);
            Eval(0525, o is object, false);
            Eval(0526, o is object[], false);
            Eval(0527, o is string, false);
            Eval(0528, o is string[], false);
            Eval(0529, o is ValueType, false);
            Eval(0530, o is ValueType[], false);
            Eval(0531, o is Array, false);
            Eval(0532, o is Array[], false);
            Eval(0533, o is Enum, false);
            Eval(0534, o is Enum[], false);
            Eval(0535, o is Delegate, false);
            Eval(0536, o is Delegate[], false);
            Eval(0537, o is MulticastDelegate, false);
            Eval(0538, o is MulticastDelegate[], false);
            Eval(0539, o is IEmpty, false);
            Eval(0540, o is IEmpty[], false);
            Eval(0541, o is INotEmpty, false);
            Eval(0542, o is INotEmpty[], false);
            Eval(0543, o is IEmptyGen<int>, false);
            Eval(0544, o is IEmptyGen<int>[], false);
            Eval(0545, o is INotEmptyGen<int>, false);
            Eval(0546, o is INotEmptyGen<int>[], false);
            Eval(0547, o is SimpleDelegate, false);
            Eval(0548, o is SimpleDelegate[], false);
            Eval(0549, o is GenericDelegate<int>, false);
            Eval(0550, o is GenericDelegate<int>[], false);
            Eval(0551, o is EmptyClass, false);
            Eval(0552, o is EmptyClass[], false);
            Eval(0553, o is NotEmptyClass, false);
            Eval(0554, o is NotEmptyClass[], false);
            Eval(0555, o is EmptyClassGen<int>, false);
            Eval(0556, o is EmptyClassGen<int>[], false);
            Eval(0557, o is NotEmptyClassGen<Guid>, false);
            Eval(0558, o is NotEmptyClassGen<Guid>[], false);
            Eval(0559, o is NotEmptyClassConstrainedGen<object>, false);
            Eval(0560, o is NotEmptyClassConstrainedGen<object>[], false);
            Eval(0561, o is NestedClass, false);
            Eval(0562, o is NestedClass[], false);
            Eval(0563, o is NestedClassGen<Decimal>, false);
            Eval(0564, o is NestedClassGen<Decimal>[], false);
            Eval(0565, o is ImplementOneInterfaceC, false);
            Eval(0566, o is ImplementOneInterfaceC[], false);
            Eval(0567, o is ImplementTwoInterfaceC, false);
            Eval(0568, o is ImplementTwoInterfaceC[], false);
            Eval(0569, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>, false);
            Eval(0570, o is ImplementOneInterfaceGenC<EmptyStructGen<int>>[], false);
            Eval(0571, o is ImplementTwoInterfaceGenC<int>, false);
            Eval(0572, o is ImplementTwoInterfaceGenC<int>[], false);
            Eval(0573, o is ImplementAllInterfaceC<int>, false);
            Eval(0574, o is ImplementAllInterfaceC<int>[], false);
            Eval(0575, o is SealedClass, false);
            Eval(0576, o is SealedClass[], false);
        }
    }  // end of test case 0003

    private static int Main()
    {
        try
        {
            TestCase0001();
            TestCase0002();
            TestCase0003();
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            Console.WriteLine("Test FAILED");
            return 666;
        }
        Console.WriteLine("Test SUCCESS");
        return 100;
    }
}
