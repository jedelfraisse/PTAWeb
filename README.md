# PTAWeb

A web application for individual PTA (Parent-Teacher Association) organizations, built with Blazor and .NET 9.

## Features

- Modern, responsive UI using Blazor
- Member management for PTA organizations
- Event scheduling and announcements
- Secure authentication and authorization
- Customizable for individual PTA needs

## Permanent Records & Yearly Reports

Each PTA organization should maintain a dedicated markdown file for permanent records and yearly reports. These files help track important information and activities over time.

**Recommended contents for each organization's record/report file:**
- Audit (Current Year)
  - Filled Audit Report
  - Full Year Transaction List (Check Register)
  - Full Year Category Report
- Budget 
  - End of Year Report
- Contracts
- Officer Information
  - Officer Form
  - Blank Signatory Page
- Membership
  - Membership List
  - Dues Payment Forms
  - Membership Flyer & Welcome Letter
- Calendar & Flyers
- Insurance
- 501c3 Letter & Sales Tax Exemption
- By-Laws & Standing Rules
- Last Year's Audit & Taxes
- Current Year 990 & 1099 Tax Filing
- Jul
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Aug
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Sept
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Oct
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Nov
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Jan
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Feb
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Mar
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Apr
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes
- Jun
  - Monthly Account Reconciliation
  - Monthly Budget Update
  - Bank Statement
  - Paypal Statement (if applicable)
  - List of Un-cleared Checks
  - Meeting Agendas
  - Meeting Minutes

> Place each organization's record in a separate `.md` file (e.g., `pta-<orgname>-records.md`) in a designated folder (such as `/Records`).

## Retention Schedule

Each PTA organization must follow a retention schedule for records and reports. The retention schedule defines how long each type of document or record should be kept before it is archived or deleted.

- **Retention rules** can be managed either in the database or displayed on a dedicated page within the application.
- The application will enforce these rules to ensure compliance and proper record management.

**Typical retention schedule items may include:**
- Financial records (e.g., audits, budgets, bank statements)
- Membership lists and officer information
- Meeting minutes and agendas
- Contracts and insurance documents
- Tax filings and legal documents

> Ensure your organization's retention schedule is documented and up to date. For implementation details, see the relevant section in the application or database.

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (recommended)

### Running the Application

1. Clone the repository:
2. Restore dependencies:
3. Build and run the project:
4. Open your browser and navigate to `https://localhost:5001` (or the URL specified in the output).

## Project Structure

- `PTAWeb/` - Main Blazor project
- `PTAWeb.Shared/` - Shared models and services
- `Records/` - Permanent records and yearly reports for each PTA organization

## Contributing

Contributions are welcome! Please open issues or submit pull requests for improvements and bug fixes.

## License

This project is licensed under the MIT License.

## Acknowledgments

- [Blazor documentation](https://learn.microsoft.com/aspnet/core/blazor/)
- .NET Community

