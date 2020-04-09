using System;
using NUnit.Framework;

namespace Hangar.UnitTests
{
    [TestFixture]
    internal class HangarTest
    {
        HangarParam _hangarParam = new HangarParam();

        [TestCase("0", "Исключение, если фамилия - пустая строка", TestName =
            "Присвоение пустой строки в качестве фамилии")]
        [TestCase("100",
            "Исключение, если фамилия длиннее 40 символов", TestName =
                "Присвоение неправильной фамилии больше 40 символов")]
        public void TestHangarWidthSet_ArgumentException(double wrong, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _hangarParam.HangarWidth = wrong; },
                message);

        }

        [Test(Description = "Проверка фамилии")]
        public void TestHangarWidthSet_CorrectValue()
        {
            var actual = "HangarWidth";
            var expected = _hangarParam.HangarWidth;
            Assert.AreEqual(actual, expected,
                "Сравнение сериализатора ProjectManager и встроенного.");
        }

        [TestCase(" ", "Исключение, если имя - пустая строка", TestName =
            "Присвоение пустой строки в качестве имени")]
        [TestCase("HangarLengthHangarLengthHangarLengthHangarLengthHangarLengthHangarLengthHangarLengthHangarLengthHangarLengthnmanem",
            "Исключение, если имя длиннее 40 символов", TestName =
                "Присвоение неправильное имя больше 40 символов")]
        [TestCase("HangarLength", "Исключение, если имя - с маленькой буквы", TestName =
            "Присвоение имени с маленькой буквы")]
        public void TestNameSet_ArgumentException(double wrongHangarLength, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _hangarParam.HangarLength = wrongHangarLength; },
                message);
        }

        [Test(Description = "Проверка имени")]
        public void TestNameSet_CorrectValue()
        {
            var actual = "HangarLength";
            var expected = _hangarParam.HangarLength;
            Assert.AreEqual(actual, expected,
                "Сравнение сериализатора ProjectManager и встроенного.");
        }


        [TestCase("05/05/2025", "Исключение, если дата больше текущей",
            TestName = "Присвоение даты больше текущей")]
        public void TestBirthdaySet_ArgumentException(double wrongString, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _hangarParam.HangarWidth = wrongString; },
                message);
        }

        [Test(Description = "Проверка даты")]
        public void TestBirthdaySet_CorrectValue()
        {
            double actual = 10;
            double expected = _hangarParam.HangarWidth;
            Assert.AreEqual(actual, expected,
                "Сравнение сериализатора ProjectManager и встроенного.");
        }

        [TestCase("8(999)499-51-03", "Исключение, если номер не начинается с +7",
            TestName = "Номер начинается не с +7")]
        [TestCase("+7999499-51-03", "Исключение, если цифры оператора без скобок",
            TestName = "Номер без скобок")]
        [TestCase("+7(999)4995103", "Исключение, если номер без дифисов",
            TestName = "Номер без дифиса")]
        public void TestGateHeigthSet_ArgumentException(double wrongGateHeigth, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _hangarParam.GateHeight = wrongGateHeigth; },
                message);
        }


        [Test(Description = "Проверка номера")]
        public void TestGateHeigthSet_CorrectValue()
        {
            var actual = "+7(777)777-77-77";
            var expected = _hangarParam.GateHeight;
            Assert.AreEqual(actual, expected,
                "Сравнение сериализатора ProjectManager и встроенного.");
        }

        [TestCase("@mail.com", "Исключение, если почта не имеет именной части",
            TestName = "Почта без имени")]
        [TestCase("listmail.com", "Исключение, если нет символа @",
            TestName = "Почта без символа @")]
        [TestCase("evsyukov@.com", "Исключение, если почта не имеет название сайта",
            TestName = "Почта без названия сайта")]
        [TestCase("evsyukov@mail", "Исключение, если почта не имеет домена",
            TestName = "Почта без домена")]
        public void TestMailSet_ArgumentException(double wrongMail, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _hangarParam.GateHeight = wrongMail; },
                message);
        }


        [Test(Description = "Проверка фамилии")]
        public void TestMailSet_CorrectValue()
        {
            var actual = "mail@mail.com";
            var expected = _hangarParam.GateHeight;
            Assert.AreEqual(actual, expected,
                "Сравнение сериализатора ProjectManager и встроенного.");
        }

        [TestCase("", "Исключение, если VkID пустая строка ",
            TestName = "VkID пустая строка")]
        [TestCase("idevsyu.kov", "Исключение, если VkID не буква или цифра ",
            TestName = "VkID с другими символами")]
        public void TestVkIdSet_ArgumentException(double wrongVkId, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _hangarParam.GateHeight = wrongVkId; },
                message);
        }

        [Test(Description = "Проверка фамилии")]
        public void TestVkIdSet_CorrectValue()
        {
            var actual = "id";
            var expected = _hangarParam.GateWidth;
            Assert.AreEqual(actual, expected,
                "Сравнение сериализатора ProjectManager и встроенного.");
        }
    }
}