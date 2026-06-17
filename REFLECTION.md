# Reflection: InventoryHub Capstone Project

## Copilot’s Contributions
- **Integration (Activity 1):** Copilot generated the initial HttpClient logic and helped scaffold the `FetchProducts.razor` component.
- **Debugging (Activity 2):** Copilot identified mismatched API routes, suggested CORS configuration, and added error handling for malformed JSON.
- **JSON Structuring (Activity 3):** Copilot guided the creation of strongly typed records with nested category objects, ensuring standardized API responses.
- **Optimization (Activity 4):** Copilot recommended dependency injection for HttpClient, caching strategies in the back‑end, and refactoring repetitive code.

## Challenges & Solutions
- **CORS restrictions** initially blocked API calls. Copilot provided a working middleware configuration.
- **Malformed JSON** broke deserialization. Copilot suggested robust try/catch handling and case‑insensitive options.
- **Performance bottlenecks** from redundant API calls were solved by caching and DI patterns.

## Key Learnings
- Copilot accelerates development by scaffolding boilerplate code and suggesting best practices.
- It is most effective when paired with developer judgment — validating, refining, and testing its suggestions.
- Using Copilot in a full‑stack context demonstrated how AI can streamline integration, debugging, and optimization across both front‑end and back‑end layers.
