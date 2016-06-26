using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Common.Interfaces;
using Moq;
using Common.Repositories;
using TomaszKlos_EQTechnicalExercise.Presenters;
using System.Collections.Generic;
using Common.Models;
using System.Linq;

namespace TomaszKlos_EQTechnicalExercise.Tests
{
    /// <summary>
    /// Testing.
    /// </summary>
    [TestFixture]
    public class TomaszKlos_EQTechnicalExerciseTest
    {
        private Mock<IMainView> fundsViewMock;
        private Mock<FundRepository> fundsRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            fundsViewMock = new Mock<IMainView>();
            fundsRepositoryMock = new Mock<FundRepository>();
        }

        [TearDown]
        public void TearDown() { fundsViewMock = null; fundsRepositoryMock = null; }

        [Test]
        public void ItShouldShowInitialFundListNotNUll()
        {
            IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;


            NUnit.Framework.Assert.IsNotNull(mockView.Funds);

        }

        [Test]
        public void ItShouldShowInitialFundListObjectsNotNUll()
        {
            IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;

            foreach (var r in mockView.Funds)
            {
                NUnit.Framework.Assert.IsNotNull(r);
            }
        }

        [Test]
        public void ItShouldShowInitialFundList()
        {

            IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;
            NUnit.Framework.Assert.AreEqual(3, mockView.Funds.Count);

        }


        [Test]
        public void ItShouldLoadAllFunds()
        {
            // Act
            var clientsPresenter = new FundPresenter(fundsViewMock.Object, fundsRepositoryMock.Object);
            // Assert
            fundsViewMock.Verify(view => view.LoadFunds(It.IsAny<IList<Fund>>()), "Expected funds to be loaded on initialization.");
        }

        [Test]
        public void ItShouldReturnObjectToAdd()
        {
            IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;

            var f = mockView.GetFund();

            NUnit.Framework.Assert.IsNotNull(f);

        }
        [Test]
        public void ItShouldCheckInitialLoad()
        {
            IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;

            var f = mockView.GetFund();

            NUnit.Framework.Assert.AreEqual("3",mockView.Total);
        }
        [Test]
        public void ItShouldCheckInitialLoadPresenter()
        {
            IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;


            NUnit.Framework.Assert.AreEqual(3, presenter.Total);
        }

        [Test]
        public void ItShouldFailOnInitialLoad()
        {
            IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;

            NUnit.Framework.Assert.IsFalse( mockView.Validate());
        }

        [Test]
        public void ItShouldLoadFunds()
        {
         IList<Fund> funds = new List<Fund>()
        {
            new Fund { Id=1,Stock = Stock.Equity, StockName = "Equity1", Price=10,Quantity=10,StockWeight=10 },
            new Fund { Id=2,Stock = Stock.Bond, StockName = "Bond1", Price=5,Quantity=5,StockWeight=5 },
            new Fund { Id=3,Stock = Stock.Bond, StockName = "Equity2", Price=20,Quantity=100,StockWeight=90 },
            new Fund { Id=4,Stock = Stock.Bond, StockName = "Equity3", Price=20,Quantity=100,StockWeight=90 },
        };

        IFundRepository fundsRepository = new FundRepository();
            MainForm mockView = new MainForm(fundsRepository);
            IPresenter presenter = mockView.Presenter;
            mockView.LoadFunds(funds);

            NUnit.Framework.Assert.AreEqual(4,mockView.Funds.Count);

        }

    }
}
