# Copilot Suggestions
- When specifying a file, please include the **project name** and **file name** for clarity.
 
# Architectural Requirements

- **Screaming Architecture:**  
  Organize code so that business/domain concepts are immediately visible at the top level. Avoid technical or generic folder names.

- **Onion Architecture:**  
  - Keep business logic and models in the Domain layer, with no dependencies on other layers.
  - Application layer orchestrates use cases and depends only on Domain.
  - Infrastructure and Presentation layers depend on Application, never the other way around.
  - Enforce dependencies via project references and code reviews.