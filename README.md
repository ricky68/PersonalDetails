Hi,

This took me just over 1hr 40mins.
(Note: I was told in the 1st interview that I should spend around 1hr 30 mins on the task, but there is no mention of this in the information I received on the technical exercise)
For this reason I made sure the actual exercises where completed, but left a lot of the things I would like to have done out.

There are a few things I'd like to do after running out of time.
1. Finish the last test.
   I did start with TDD, but after looking at the time it was taking up, I decided you would be more likely to want the response completed.
2. Add some error checking.
   This could be done by injecting an error handler service.
   Instead of wrapping the result with Ok(Result), we would then use a try catch and return the exception, probably StatusCode 500, with the exception details.
3. There is some duplicate code, that works out someone’s next birthday, this should be refactored into a private method. There is no need to expose it as it will be tested when calling the public methods that use it.
4. Change the result set for the 14 days to list the days by their 3 letter abbreviations.
5. I like the look of minimal API's for the controllers and would be tempted to refactor and use these as it's fresh code.
   Again a design decision was made that you might not be looking for this.
6. I know this isn't going into production, but if it was I would definitely have added CORS by now.

Thank you,
Ricky Melville

