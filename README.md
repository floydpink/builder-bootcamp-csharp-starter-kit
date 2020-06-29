# builder-bootcamp-csharp-starter-kit

> The .NET Core solution within this startup kit was created from [this article](https://aws.amazon.com/blogs/compute/developing-net-core-aws-lambda-functions/)

## Requirements

* AWS CLI already configured with Administrator permission
* Git installed and configured
* [Dotnet 3.1+ installed](https://dotnet.microsoft.com/download)
* [Docker installed](https://www.docker.com/community-edition)

## Initial setup & deployment

**Prepare the infrastructure**

1. Create an S3 bucket
```bash
aws s3 mb s3://bootcamp-starter-kit-$USER
```

2. Deploy the infrastructure
```bash
make infra
```

**Deploy the application**

1. Add a new git remote and point it at the CodeCommit repo created by `make infra`
```bash
git remote add codecommit <codecommit-clone-url-http>
```

2. Push your changes and the pipeline should kick off a build
```bash
git push -u codecommit master
```

> Check out [this article](https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-https-unixes.html) to get help with setting up CodeCommit repo.

## Local development

### Requirements

* AWS CLI
* AWS SAM CLI
* [Dotnet 3.1+ installed](https://dotnet.microsoft.com/download)
* [Docker installed](https://www.docker.com/community-edition)

Please refer to the troubleshooting section for help with setting up authentication and authorization

**Run unit tests**

1. Run the unit tests
```bash
make test
```

2. Hope they work!


**Publish and invoke locally**

1. Publish the Lambda functions locally
```bash
dotnet publish -c Release
```

2. Invoke the Lambda functions locally
```bash
sam local invoke "GetLambdaFunction" --event payload.json
```

3. Start API Gateway locally
```bash
sam local start-api
```

4. Test your work at the address(es) returned

**Troubleshooting**

If you face the `The requested URL returned error: 403` error while performing git operations:

1. Check if your AWS account user being used has the following 3 permissions:
    1. AWSCodeCommitFullAccess
    2. AWSCodeCommitPowerUser
    3. AWSCodeCommitReadOnly

2. Make sure git credentials are setup properly as described [here](https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-gc.html)