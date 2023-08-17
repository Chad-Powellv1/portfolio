using ErrorOr;

namespace Portfolio.Domain.Common.Errors;

public static partial class Errors {

    public static partial class User {

        public static Error DuplicateEmail => Error.Conflict(
            code: "User.DuplicateEmail",
            description: "The email address is already in use."
        );
    }
}
