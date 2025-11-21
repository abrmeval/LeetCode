# LeetCode Solutions Repository - AI Coding Instructions

## Project Overview
This is a multi-language competitive programming repository containing LeetCode problem solutions and sorting algorithm implementations in Python and .NET C#. The project follows a language-segregated structure with consistent patterns across implementations.

## Directory Structure & Conventions

### Language Organization
```
LeetCode/
├── Python/
│   ├── problems/           # LeetCode problem solutions
│   └── sorting_algorithms/ # Fundamental sorting implementations
├── .NET/
│   ├── problems/           # C# LeetCode solutions (project per problem)
│   └── sorting_algorithms/ # (planned, currently empty)
└── Go/                     # (planned, currently empty)
```

### File Naming Patterns
- **Python**: `snake_case.py` (e.g., `two_sum.py`, `palindrome_number.py`)
- **.NET**: `PascalCase/` directories with `Solution1.cs`, `Solution2.cs` for multiple approaches
- Sorting algorithms: descriptive names like `bubble_sort.py`, `selection_sort.py`

## Coding Patterns & Standards

### Python Implementation Style
```python
# Dual implementation pattern - always include both:
class Solution(object):  # LeetCode-compatible format
    def twoSum(self, nums, target):
        """Standard LeetCode docstring format"""
        # Implementation with type hints in comments

def two_sum(nums: list[int], target: int) -> list[int]:
    """Modern Python with proper type hints"""
    # Clean implementation

# Always include test execution at file level
print("Problem Description")
result = solution_function(test_inputs)
print("Expected output format:", result)
```

### C# Project Structure
- Each LeetCode problem gets its own console project under `.NET/problems/`
- Multiple solution approaches in separate `Solution1.cs`, `Solution2.cs` files
- Projects use top-level programs with `Program.cs` for testing
- All projects are included in the main `LeetCode.sln`

### Documentation Standards
- **Comprehensive comments**: Include desktop test walkthroughs for complex algorithms
- **Complexity analysis**: Always document time/space complexity for sorting algorithms  
- **Test cases**: Include multiple test cases with expected outputs in comments
- **Algorithm explanations**: Explain the "why" behind approach, not just the "what"

## Development Workflow

### Running Solutions
- **Python**: Direct execution `python filename.py` - files are self-contained with test cases
- **.NET**: Use Visual Studio or `dotnet run` in project directories
- **Solution file**: `LeetCode.sln` manages all C# projects

### Adding New Problems
1. **Python**: Create in appropriate subdirectory with dual implementation pattern
2. **.NET**: Create new console project, update solution file, use namespace matching directory
3. Always include comprehensive test cases and complexity analysis
4. Follow existing naming conventions strictly

### Key Implementation Details
- Python solutions use both legacy LeetCode format and modern Python patterns
- Sorting algorithms include optimization flags (e.g., early termination in bubble sort)
- C# solutions may have multiple approaches in separate files for comparison
- All solutions include step-by-step manual verification in comments

## Testing & Validation
- Files are designed for immediate execution with built-in test cases
- No external test framework required - all testing is inline
- Expected to manually verify complex algorithms with desktop testing in comments
- Print statements provide immediate feedback on correctness

This repository prioritizes educational value through detailed explanations, multiple implementation styles, and comprehensive testing approaches over production-ready code optimization.