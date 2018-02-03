/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Model;
using Elli.Api.Loans.Client;
using System.Reflection;

namespace Elli.Api.Loans.Test
{
    /// <summary>
    ///  Class for testing LoanContractDisclosureTrackingLogs
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractDisclosureTrackingLogsTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractDisclosureTrackingLogs
        //private LoanContractDisclosureTrackingLogs instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractDisclosureTrackingLogs
            //instance = new LoanContractDisclosureTrackingLogs();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractDisclosureTrackingLogs
        /// </summary>
        [Test]
        public void LoanContractDisclosureTrackingLogsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractDisclosureTrackingLogs
            //Assert.IsInstanceOfType<LoanContractDisclosureTrackingLogs> (instance, "variable 'instance' is a LoanContractDisclosureTrackingLogs");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Alerts'
        /// </summary>
        [Test]
        public void AlertsTest()
        {
            // TODO unit test for the property 'Alerts'
        }
        /// <summary>
        /// Test the property 'BorrowerPairId'
        /// </summary>
        [Test]
        public void BorrowerPairIdTest()
        {
            // TODO unit test for the property 'BorrowerPairId'
        }
        /// <summary>
        /// Test the property 'CommentList'
        /// </summary>
        [Test]
        public void CommentListTest()
        {
            // TODO unit test for the property 'CommentList'
        }
        /// <summary>
        /// Test the property 'Comments'
        /// </summary>
        [Test]
        public void CommentsTest()
        {
            // TODO unit test for the property 'Comments'
        }
        /// <summary>
        /// Test the property 'ContainGfe'
        /// </summary>
        [Test]
        public void ContainGfeTest()
        {
            // TODO unit test for the property 'ContainGfe'
        }
        /// <summary>
        /// Test the property 'ContainSafeHarbor'
        /// </summary>
        [Test]
        public void ContainSafeHarborTest()
        {
            // TODO unit test for the property 'ContainSafeHarbor'
        }
        /// <summary>
        /// Test the property 'ContainTil'
        /// </summary>
        [Test]
        public void ContainTilTest()
        {
            // TODO unit test for the property 'ContainTil'
        }
        /// <summary>
        /// Test the property 'DateUtc'
        /// </summary>
        [Test]
        public void DateUtcTest()
        {
            // TODO unit test for the property 'DateUtc'
        }
        /// <summary>
        /// Test the property 'DisclosedBy'
        /// </summary>
        [Test]
        public void DisclosedByTest()
        {
            // TODO unit test for the property 'DisclosedBy'
        }
        /// <summary>
        /// Test the property 'DisclosedByFullName'
        /// </summary>
        [Test]
        public void DisclosedByFullNameTest()
        {
            // TODO unit test for the property 'DisclosedByFullName'
        }
        /// <summary>
        /// Test the property 'DisclosedMethod'
        /// </summary>
        [Test]
        public void DisclosedMethodTest()
        {
            // TODO unit test for the property 'DisclosedMethod'
        }
        /// <summary>
        /// Test the property 'DisclosureCreatedDttmUtc'
        /// </summary>
        [Test]
        public void DisclosureCreatedDttmUtcTest()
        {
            // TODO unit test for the property 'DisclosureCreatedDttmUtc'
        }
        /// <summary>
        /// Test the property 'EDisclosureApplicationPackageIndicator'
        /// </summary>
        [Test]
        public void EDisclosureApplicationPackageIndicatorTest()
        {
            // TODO unit test for the property 'EDisclosureApplicationPackageIndicator'
        }
        /// <summary>
        /// Test the property 'EDisclosureApprovalPackageIndicator'
        /// </summary>
        [Test]
        public void EDisclosureApprovalPackageIndicatorTest()
        {
            // TODO unit test for the property 'EDisclosureApprovalPackageIndicator'
        }
        /// <summary>
        /// Test the property 'EDisclosureBorrowerAcceptConsentDate'
        /// </summary>
        [Test]
        public void EDisclosureBorrowerAcceptConsentDateTest()
        {
            // TODO unit test for the property 'EDisclosureBorrowerAcceptConsentDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureBorrowereSignedDate'
        /// </summary>
        [Test]
        public void EDisclosureBorrowereSignedDateTest()
        {
            // TODO unit test for the property 'EDisclosureBorrowereSignedDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureBorrowerRejectConsentDate'
        /// </summary>
        [Test]
        public void EDisclosureBorrowerRejectConsentDateTest()
        {
            // TODO unit test for the property 'EDisclosureBorrowerRejectConsentDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureBorrowerViewConsentDate'
        /// </summary>
        [Test]
        public void EDisclosureBorrowerViewConsentDateTest()
        {
            // TODO unit test for the property 'EDisclosureBorrowerViewConsentDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureBorrowerViewMessageDate'
        /// </summary>
        [Test]
        public void EDisclosureBorrowerViewMessageDateTest()
        {
            // TODO unit test for the property 'EDisclosureBorrowerViewMessageDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureBorrowerWetSignedDate'
        /// </summary>
        [Test]
        public void EDisclosureBorrowerWetSignedDateTest()
        {
            // TODO unit test for the property 'EDisclosureBorrowerWetSignedDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureCoBorrowerAcceptConsentDate'
        /// </summary>
        [Test]
        public void EDisclosureCoBorrowerAcceptConsentDateTest()
        {
            // TODO unit test for the property 'EDisclosureCoBorrowerAcceptConsentDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureCoBorrowereSignedDate'
        /// </summary>
        [Test]
        public void EDisclosureCoBorrowereSignedDateTest()
        {
            // TODO unit test for the property 'EDisclosureCoBorrowereSignedDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureCoBorrowerRejectConsentDate'
        /// </summary>
        [Test]
        public void EDisclosureCoBorrowerRejectConsentDateTest()
        {
            // TODO unit test for the property 'EDisclosureCoBorrowerRejectConsentDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureCoBorrowerViewConsentDate'
        /// </summary>
        [Test]
        public void EDisclosureCoBorrowerViewConsentDateTest()
        {
            // TODO unit test for the property 'EDisclosureCoBorrowerViewConsentDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureCoBorrowerViewMessageDate'
        /// </summary>
        [Test]
        public void EDisclosureCoBorrowerViewMessageDateTest()
        {
            // TODO unit test for the property 'EDisclosureCoBorrowerViewMessageDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureCoBorrowerWebSignedDate'
        /// </summary>
        [Test]
        public void EDisclosureCoBorrowerWebSignedDateTest()
        {
            // TODO unit test for the property 'EDisclosureCoBorrowerWebSignedDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureConsentPdf'
        /// </summary>
        [Test]
        public void EDisclosureConsentPdfTest()
        {
            // TODO unit test for the property 'EDisclosureConsentPdf'
        }
        /// <summary>
        /// Test the property 'EDisclosureDisclosedMessage'
        /// </summary>
        [Test]
        public void EDisclosureDisclosedMessageTest()
        {
            // TODO unit test for the property 'EDisclosureDisclosedMessage'
        }
        /// <summary>
        /// Test the property 'EDisclosureLockPackageIndicator'
        /// </summary>
        [Test]
        public void EDisclosureLockPackageIndicatorTest()
        {
            // TODO unit test for the property 'EDisclosureLockPackageIndicator'
        }
        /// <summary>
        /// Test the property 'EDisclosureManualFulfillmentComment'
        /// </summary>
        [Test]
        public void EDisclosureManualFulfillmentCommentTest()
        {
            // TODO unit test for the property 'EDisclosureManualFulfillmentComment'
        }
        /// <summary>
        /// Test the property 'EDisclosureManualFulfillmentDate'
        /// </summary>
        [Test]
        public void EDisclosureManualFulfillmentDateTest()
        {
            // TODO unit test for the property 'EDisclosureManualFulfillmentDate'
        }
        /// <summary>
        /// Test the property 'EDisclosureManualFulfillmentMethod'
        /// </summary>
        [Test]
        public void EDisclosureManualFulfillmentMethodTest()
        {
            // TODO unit test for the property 'EDisclosureManualFulfillmentMethod'
        }
        /// <summary>
        /// Test the property 'EDisclosureManuallyFulfilledBy'
        /// </summary>
        [Test]
        public void EDisclosureManuallyFulfilledByTest()
        {
            // TODO unit test for the property 'EDisclosureManuallyFulfilledBy'
        }
        /// <summary>
        /// Test the property 'EDisclosurePackageCreatedDate'
        /// </summary>
        [Test]
        public void EDisclosurePackageCreatedDateTest()
        {
            // TODO unit test for the property 'EDisclosurePackageCreatedDate'
        }
        /// <summary>
        /// Test the property 'EDisclosurePackageId'
        /// </summary>
        [Test]
        public void EDisclosurePackageIdTest()
        {
            // TODO unit test for the property 'EDisclosurePackageId'
        }
        /// <summary>
        /// Test the property 'EDisclosurePackageViewableFile'
        /// </summary>
        [Test]
        public void EDisclosurePackageViewableFileTest()
        {
            // TODO unit test for the property 'EDisclosurePackageViewableFile'
        }
        /// <summary>
        /// Test the property 'EDisclosureThreeDayPackageIndicator'
        /// </summary>
        [Test]
        public void EDisclosureThreeDayPackageIndicatorTest()
        {
            // TODO unit test for the property 'EDisclosureThreeDayPackageIndicator'
        }
        /// <summary>
        /// Test the property 'FileAttachmentsMigrated'
        /// </summary>
        [Test]
        public void FileAttachmentsMigratedTest()
        {
            // TODO unit test for the property 'FileAttachmentsMigrated'
        }
        /// <summary>
        /// Test the property 'Forms'
        /// </summary>
        [Test]
        public void FormsTest()
        {
            // TODO unit test for the property 'Forms'
        }
        /// <summary>
        /// Test the property 'FulfillmentOrderedBy'
        /// </summary>
        [Test]
        public void FulfillmentOrderedByTest()
        {
            // TODO unit test for the property 'FulfillmentOrderedBy'
        }
        /// <summary>
        /// Test the property 'FullfillmentProcessedDate'
        /// </summary>
        [Test]
        public void FullfillmentProcessedDateTest()
        {
            // TODO unit test for the property 'FullfillmentProcessedDate'
        }
        /// <summary>
        /// Test the property 'Guid'
        /// </summary>
        [Test]
        public void GuidTest()
        {
            // TODO unit test for the property 'Guid'
        }
        /// <summary>
        /// Test the property 'IsDisclosed'
        /// </summary>
        [Test]
        public void IsDisclosedTest()
        {
            // TODO unit test for the property 'IsDisclosed'
        }
        /// <summary>
        /// Test the property 'IsDisclosedAprLocked'
        /// </summary>
        [Test]
        public void IsDisclosedAprLockedTest()
        {
            // TODO unit test for the property 'IsDisclosedAprLocked'
        }
        /// <summary>
        /// Test the property 'IsDisclosedByLocked'
        /// </summary>
        [Test]
        public void IsDisclosedByLockedTest()
        {
            // TODO unit test for the property 'IsDisclosedByLocked'
        }
        /// <summary>
        /// Test the property 'IsDisclosedFinanceChargeLocked'
        /// </summary>
        [Test]
        public void IsDisclosedFinanceChargeLockedTest()
        {
            // TODO unit test for the property 'IsDisclosedFinanceChargeLocked'
        }
        /// <summary>
        /// Test the property 'IsDisclosedReceivedDateLocked'
        /// </summary>
        [Test]
        public void IsDisclosedReceivedDateLockedTest()
        {
            // TODO unit test for the property 'IsDisclosedReceivedDateLocked'
        }
        /// <summary>
        /// Test the property 'IsLocked'
        /// </summary>
        [Test]
        public void IsLockedTest()
        {
            // TODO unit test for the property 'IsLocked'
        }
        /// <summary>
        /// Test the property 'IsSystemSpecificIndicator'
        /// </summary>
        [Test]
        public void IsSystemSpecificIndicatorTest()
        {
            // TODO unit test for the property 'IsSystemSpecificIndicator'
        }
        /// <summary>
        /// Test the property 'IsWetSignedIndicator'
        /// </summary>
        [Test]
        public void IsWetSignedIndicatorTest()
        {
            // TODO unit test for the property 'IsWetSignedIndicator'
        }
        /// <summary>
        /// Test the property 'LockedDisclosedAprField'
        /// </summary>
        [Test]
        public void LockedDisclosedAprFieldTest()
        {
            // TODO unit test for the property 'LockedDisclosedAprField'
        }
        /// <summary>
        /// Test the property 'LockedDisclosedByField'
        /// </summary>
        [Test]
        public void LockedDisclosedByFieldTest()
        {
            // TODO unit test for the property 'LockedDisclosedByField'
        }
        /// <summary>
        /// Test the property 'LockedDisclosedFinanceChargeField'
        /// </summary>
        [Test]
        public void LockedDisclosedFinanceChargeFieldTest()
        {
            // TODO unit test for the property 'LockedDisclosedFinanceChargeField'
        }
        /// <summary>
        /// Test the property 'LockedDisclosedReceivedDate'
        /// </summary>
        [Test]
        public void LockedDisclosedReceivedDateTest()
        {
            // TODO unit test for the property 'LockedDisclosedReceivedDate'
        }
        /// <summary>
        /// Test the property 'LogRecordIndex'
        /// </summary>
        [Test]
        public void LogRecordIndexTest()
        {
            // TODO unit test for the property 'LogRecordIndex'
        }
        /// <summary>
        /// Test the property 'ManuallyCreated'
        /// </summary>
        [Test]
        public void ManuallyCreatedTest()
        {
            // TODO unit test for the property 'ManuallyCreated'
        }
        /// <summary>
        /// Test the property 'ReceivedDate'
        /// </summary>
        [Test]
        public void ReceivedDateTest()
        {
            // TODO unit test for the property 'ReceivedDate'
        }
        /// <summary>
        /// Test the property 'SnapshotFields'
        /// </summary>
        [Test]
        public void SnapshotFieldsTest()
        {
            // TODO unit test for the property 'SnapshotFields'
        }
        /// <summary>
        /// Test the property 'SystemId'
        /// </summary>
        [Test]
        public void SystemIdTest()
        {
            // TODO unit test for the property 'SystemId'
        }
        /// <summary>
        /// Test the property 'FormsXml'
        /// </summary>
        [Test]
        public void FormsXmlTest()
        {
            // TODO unit test for the property 'FormsXml'
        }
        /// <summary>
        /// Test the property 'SnapshotXml'
        /// </summary>
        [Test]
        public void SnapshotXmlTest()
        {
            // TODO unit test for the property 'SnapshotXml'
        }
        /// <summary>
        /// Test the property 'ApplicationDate'
        /// </summary>
        [Test]
        public void ApplicationDateTest()
        {
            // TODO unit test for the property 'ApplicationDate'
        }
        /// <summary>
        /// Test the property 'BorrowerName'
        /// </summary>
        [Test]
        public void BorrowerNameTest()
        {
            // TODO unit test for the property 'BorrowerName'
        }
        /// <summary>
        /// Test the property 'CoBorrowerName'
        /// </summary>
        [Test]
        public void CoBorrowerNameTest()
        {
            // TODO unit test for the property 'CoBorrowerName'
        }
        /// <summary>
        /// Test the property 'DisclosedAPR'
        /// </summary>
        [Test]
        public void DisclosedAPRTest()
        {
            // TODO unit test for the property 'DisclosedAPR'
        }
        /// <summary>
        /// Test the property 'FinanceCharge'
        /// </summary>
        [Test]
        public void FinanceChargeTest()
        {
            // TODO unit test for the property 'FinanceCharge'
        }
        /// <summary>
        /// Test the property 'LoanProgram'
        /// </summary>
        [Test]
        public void LoanProgramTest()
        {
            // TODO unit test for the property 'LoanProgram'
        }
        /// <summary>
        /// Test the property 'LoanAmount'
        /// </summary>
        [Test]
        public void LoanAmountTest()
        {
            // TODO unit test for the property 'LoanAmount'
        }
        /// <summary>
        /// Test the property 'PropertyAddress'
        /// </summary>
        [Test]
        public void PropertyAddressTest()
        {
            // TODO unit test for the property 'PropertyAddress'
        }
        /// <summary>
        /// Test the property 'PropertyCity'
        /// </summary>
        [Test]
        public void PropertyCityTest()
        {
            // TODO unit test for the property 'PropertyCity'
        }
        /// <summary>
        /// Test the property 'PropertyState'
        /// </summary>
        [Test]
        public void PropertyStateTest()
        {
            // TODO unit test for the property 'PropertyState'
        }
        /// <summary>
        /// Test the property 'PropertyZip'
        /// </summary>
        [Test]
        public void PropertyZipTest()
        {
            // TODO unit test for the property 'PropertyZip'
        }
        /// <summary>
        /// Test the property 'AlertsXml'
        /// </summary>
        [Test]
        public void AlertsXmlTest()
        {
            // TODO unit test for the property 'AlertsXml'
        }
        /// <summary>
        /// Test the property 'CommentListXml'
        /// </summary>
        [Test]
        public void CommentListXmlTest()
        {
            // TODO unit test for the property 'CommentListXml'
        }

    }

}