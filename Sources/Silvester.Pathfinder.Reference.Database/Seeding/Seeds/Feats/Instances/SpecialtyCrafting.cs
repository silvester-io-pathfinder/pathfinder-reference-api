using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpecialtyCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("c8776d3f-3b22-4865-bb34-af566eb552e3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Specialty Crafting",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2d83f65-3d0a-4bc7-9c8a-04f1b53584c5"), Type = TextBlockType.Text, Text = "Your training focused on (action: Crafting | Craft) one particular kind of item. Select one of the specialties listed below; you gain a +1 circumstance bonus to Crafting checks to (action: Craft) items of that type. If you are a master in Crafting, this bonus increases to +2. If it’s unclear whether the specialty applies, the GM decides. Some specialties might apply only partially. For example, if you were making a morningstar and had specialty in woodworking, the GM might give you half your bonus because the item requires both blacksmithing and woodworking." };
            yield return new TextBlock { Id = Guid.Parse("f44d7b77-45e0-4c6c-a736-02eb952bacdc"), Type = TextBlockType.Enumeration, Text = "**Specialties***" };
            yield return new TextBlock { Id = Guid.Parse("7ed9901d-082b-4708-ad2e-e2b556bc6953"), Type = TextBlockType.Enumeration, Text = " Alchemy: Alchemical items such as elixirs" };
            yield return new TextBlock { Id = Guid.Parse("22b10009-344c-4af4-a69a-0593a28fef24"), Type = TextBlockType.Enumeration, Text = " Artistry: Fine art, including jewelry" };
            yield return new TextBlock { Id = Guid.Parse("c81c572c-a7c8-4fce-ac86-b7b37adc2933"), Type = TextBlockType.Enumeration, Text = " Blacksmithing: Durable metal goods, including metal armor" };
            yield return new TextBlock { Id = Guid.Parse("b71bd435-6d33-4ec7-beef-f8ab6f5261e9"), Type = TextBlockType.Enumeration, Text = " Bookmaking: Books and paper" };
            yield return new TextBlock { Id = Guid.Parse("28a6540a-fb04-4312-a148-b0c83a854f19"), Type = TextBlockType.Enumeration, Text = " Glassmaking: Glass, including glassware and windows" };
            yield return new TextBlock { Id = Guid.Parse("368719ca-ce3d-4ccc-bc0b-cc279ef98f0a"), Type = TextBlockType.Enumeration, Text = " Leatherworking: Leather goods, including leather armor" };
            yield return new TextBlock { Id = Guid.Parse("143e306c-6174-4ed2-8d84-d728590e5cc1"), Type = TextBlockType.Enumeration, Text = " Pottery: Ceramic goods" };
            yield return new TextBlock { Id = Guid.Parse("ad3e22ca-6008-49fa-b504-3ec6abec95e2"), Type = TextBlockType.Enumeration, Text = " Shipbuilding: Ships and boats" };
            yield return new TextBlock { Id = Guid.Parse("1a49db74-95ed-4ee6-83af-f2d571ffe73f"), Type = TextBlockType.Enumeration, Text = " Stonemasonry: Stone goods and structures" };
            yield return new TextBlock { Id = Guid.Parse("1ea41e19-58a1-4c07-bb7b-de79246b3045"), Type = TextBlockType.Enumeration, Text = " Tailoring: Clothing" };
            yield return new TextBlock { Id = Guid.Parse("ae83620d-e248-4e0d-9b50-182ae326d7ed"), Type = TextBlockType.Enumeration, Text = " Weaving: Textiles, baskets, and rugs" };
            yield return new TextBlock { Id = Guid.Parse("8e20ab24-2f05-4181-b06b-c86ddd3abcef"), Type = TextBlockType.Enumeration, Text = " Woodworking: Wooden goods and structures" };
            yield return new TextBlock { Id = Guid.Parse("b74f063a-b7bd-403c-9dc8-94e0aac1a797"), Type = TextBlockType.Text, Text = "You must have the (feat: Alchemical Crafting) skill feat to (action: Craft) alchemical items." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6d445f4f-850b-4040-8829-a63602ddf450"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07b98f60-f141-499b-92ff-b6fc1f60f224"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
