Reset: git reset --hard

//Basic
git config user.name "James Stenzel"
git config user.email "jhs01@acuitysso.com"
git config --global user.name "James Stenzel"
git config --global user.email "jhs01@acuitysso.com"


git diff <commitid1> > <patch_filename>.patch

Apply Patch…
git apply "file.pactch"



git diff origin/develop... | grep "^+.*    .*$"

//Fix Conflict:
-Go on to dev and sync
-Go on to feature branch
-Then merge dev to your feature branch
-Fix then commit
