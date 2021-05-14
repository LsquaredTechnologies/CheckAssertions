# Expect Assertion

[![Build Status](https://dev.azure.com/lsquared/ExpectAssertions/_apis/build/status/ExpectAssertions?branchName=azure-pipelines)](https://dev.azure.com/lsquared/ExpectAssertions/_build/latest?definitionId=6&branchName=azure-pipelines)

This is another assertion library which integrate to any testing framework
like xUnit, NUnit, or MSTest (v1 or v2).

## Documentation

### Usage

In order to verify your assertion, you simply need to use `Expect.That()` with the the you want to check
and intellisense will guide you with fluent methods:

```csharp
// Assert
Expect.That(actualValue).IsEqualTo(expectedValue);
```

You can chain multiple assertions with the `And()` method to have a nice real english sentence.

```csharp
// Assert
Expect.That(actualValue).Matches(expectedPattern).And().DoesNotMatch(nonExpectedPattern);
```

# Contribute

Do not hesitate to contact me if you want new features.
