# PropertyView.GroupingHeader
Episerver property view grouping header

what it looks like when its up and running:

![image](https://user-images.githubusercontent.com/12612426/110833779-0a83a800-825a-11eb-9b26-111a73d2bc39.png)

How to get this working:

First: install the nuget package: https://www.nuget.org/packages/PropertyView.GroupingHeader

Once installed, you need to add the following:

![image](https://user-images.githubusercontent.com/12612426/110834290-9bf31a00-825a-11eb-8403-e8365b96a978.png)
- create folder: PropertyView.GroupingHeader
- Copy the contents of the folder in this project and paste them in. the .zip file is for Epi, the non zipped files are to edit, rezip and reuse.

Then you will use the package in your code:
- on your blocks types, or page types
    - using PropertyView.GroupingHeader;
- then above one of the properties that you want to group together
    - [GroupingHeader("Settings - UI elements")]
- You can now have header elements in your property views for anyone editing content. Just helps organize properties.

![image](https://user-images.githubusercontent.com/12612426/110834844-4b2ff100-825b-11eb-9ce4-199227b0fd63.png)


From the Original Docs

To group properties use GroupingHeader attribute. Attribute should be placed on the property.

[GroupingHeader("Sample group")]
[Display(GroupName = "Company", Order = 1)]
public virtual string TestProperty1 { get; set; }


Attrbiute can be used with second parameter which is class name:

[GroupingHeader("Sample group", "custom-class")]
[Display(GroupName = "Company", Order = 1)]
public virtual string TestProperty1 { get; set; }

In Alloy demo custom edit mode styles are in "\ClientResources\Styles\Styles.css"


The third parameter of GroupingHeader is tag.

[GroupingHeader("Sample group", "custom-class", "span")]
[Display(GroupName = "Company", Order = 1)]
public virtual string TestProperty1 { get; set; }

By default header is rendered using "h2".
