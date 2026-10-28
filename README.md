# 🚀 TaxEase — Individual & Corporate Annual Income Tax (SPT) Reporting Integration System

A smart desktop application designed to simplify the process for both individual taxpayers (employees) and corporate entities (employers) in managing tax withholding slips, simulating tax calculations, and preparing annual SPT reporting ahead of the Directorate General of Taxes (DJP) Coretax system transition in Indonesia.

---

## 📖 Overview

**TaxEase** is an innovative solution developed to address common challenges faced by individual taxpayers and corporate organizations when reporting Annual Income Tax Returns (SPT Tahunan PPh). This application bridges data between employers and the DJP system by providing automated document extraction, year-end calculation simulations (Zero/Nihil, Overpayment/Lebih Bayar, or Underpayment/Kurang Bayar), bulk corporate payroll data management, and accurate form column placement guides to prevent input errors and administrative penalties. 

*Note: This application functions as a pre-flight preparation and simulation tool to guide users before final submission on the official DJP Coretax web portal.*

---

## ✨ Key Features & Capabilities

* 👤 **Individual Taxpayer Modules:**
  * **Profile & Family Management:** Dynamic management of personal data, marital status, and family dependents to ensure accurate PTKP calculations.
  * **Withholding Slip Management & Extraction:** Bulk upload of monthly tax withholding PDF documents with automated data extraction and manual verification options.
  * **Tax Status Simulation & Prediction:** An automated rule-based calculator that projects the final status of your Annual SPT (*Zero/Nihil, Overpayment/Lebih Bayar, or Underpayment/Kurang Bayar*) based on accumulated income.
  * **SPT Column Filling Guide:** Interactive visual guidelines that steer individual users in mapping calculation results accurately to the official form columns on the DJP Coretax system.

* 🏢 **Corporate / Employer & Admin Modules:**
  * **Bulk Payroll Import:** Seamless mass data import of employee salaries and tax records via Excel/CSV files (`.csv/.xlsx`).
  * **Compliance Monitoring:** Real-time dashboards monitoring employee SPT reporting statuses (Completed, Pending, or Overdue).
  * **Official Document Generation:** Automated generation and printing/exporting of official tax withholding slips (Form 1721-A1) for corporate employees.
  * **User Management & Broadcasting:** Administrative control over user accounts, document validation, credential verification, and administrative broadcast notifications.

---

## 🛠️ Tech Stack & Architecture

* 💻 **Programming Language:** Visual Basic .NET (VB.NET)
* 🖥️ **Presentation Layer:** Windows Forms (WinForms)
* 🗄️ **Database Management System:** Microsoft SQL Server 2022 Express / SQL Server Management Studio (SSMS)
* 📑 **Reporting Engine:** Crystal Reports / RDLC for automated PDF generation (Form 1721-A1)
* 📂 **Data Integration:** Spreadsheet reader for secure CSV/Excel bulk data ingestion

---

## 💡 Step-by-Step Usage Guide

1. 🔐 **Login & Registration:** Launch the desktop application, select your entity type (Individual or Corporate), log in securely using your credentials, and complete your profile data.
2. 📤 **Data Management & Uploads:** 
   * *For Individuals:* Upload tax withholding PDF receipts from employers for automated extraction and manual checks.
   * *For Corporations:* Import mass employee salary datasets via CSV/Excel templates and review them via the DataGridView preview table.
3. 📊 **Simulation & Status Check:** Run annual calculations and compliance monitoring to preview SPT statuses (*Zero, Overpayment, or Underpayment*) and track corporate reporting progress.
4. 🧭 **Filling Guide & Submission:** Follow intuitive step-by-step guidance or export official corporate reports (Form 1721-A1) to finalize submissions on the official DJP Coretax portal.
