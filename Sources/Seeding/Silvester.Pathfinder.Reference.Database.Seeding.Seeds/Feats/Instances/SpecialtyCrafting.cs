using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpecialtyCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("f61ab64c-382d-4755-881d-2abe4b19a2da");

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
            yield return new TextBlock { Id = Guid.Parse("4e8e9c4b-8ead-4862-ab1c-a48059045399"), Type = TextBlockType.Text, Text = $"Your training focused on {ToMarkdownLink<Models.Entities.SkillAction>("Crafting", SkillActions.Instances.Craft.ID)} one particular kind of item. Select one of the specialties listed below; you gain a +1 circumstance bonus to Crafting checks to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} items of that type. If you are a master in Crafting, this bonus increases to +2. If it's unclear whether the specialty applies, the GM decides. Some specialties might apply only partially. For example, if you were making a morningstar and had specialty in woodworking, the GM might give you half your bonus because the item requires both blacksmithing and woodworking." };
            yield return new TextBlock { Id = Guid.Parse("50972550-734c-47ef-b1fa-4cd2ca7bb7e1"), Type = TextBlockType.Enumeration, Text = $"**Specialties***" };
            yield return new TextBlock { Id = Guid.Parse("830e92fa-321f-4755-a746-9d41291a0eff"), Type = TextBlockType.Enumeration, Text = $" Alchemy: Alchemical items such as elixirs" };
            yield return new TextBlock { Id = Guid.Parse("df244bcf-2246-4098-b7f2-fce342a30eca"), Type = TextBlockType.Enumeration, Text = $" Artistry: Fine art, including jewelry" };
            yield return new TextBlock { Id = Guid.Parse("eef78fb8-0ae6-4d84-a550-3b0a7f486c3d"), Type = TextBlockType.Enumeration, Text = $" Blacksmithing: Durable metal goods, including metal armor" };
            yield return new TextBlock { Id = Guid.Parse("152f8f05-0d63-4468-9883-9da5c14bfe17"), Type = TextBlockType.Enumeration, Text = $" Bookmaking: Books and paper" };
            yield return new TextBlock { Id = Guid.Parse("59250450-75d7-44d9-9b8b-2f5aca871501"), Type = TextBlockType.Enumeration, Text = $" Glassmaking: Glass, including glassware and windows" };
            yield return new TextBlock { Id = Guid.Parse("1694e44c-9e04-47cc-bd15-8ad2a3b39b9a"), Type = TextBlockType.Enumeration, Text = $" Leatherworking: Leather goods, including leather armor" };
            yield return new TextBlock { Id = Guid.Parse("c0f035c6-cb72-4dea-925b-25fb2db1e9f7"), Type = TextBlockType.Enumeration, Text = $" Pottery: Ceramic goods" };
            yield return new TextBlock { Id = Guid.Parse("5e977ba8-720e-4043-9f66-8aaa1d45e80f"), Type = TextBlockType.Enumeration, Text = $" Shipbuilding: Ships and boats" };
            yield return new TextBlock { Id = Guid.Parse("8464aeff-e446-41da-8f0f-f0df2eaa9a76"), Type = TextBlockType.Enumeration, Text = $" Stonemasonry: Stone goods and structures" };
            yield return new TextBlock { Id = Guid.Parse("2b8b30e1-ae7f-4ee2-8ade-1c37c0317613"), Type = TextBlockType.Enumeration, Text = $" Tailoring: Clothing" };
            yield return new TextBlock { Id = Guid.Parse("3ba22c75-d1c6-4832-b3ef-04c2390da135"), Type = TextBlockType.Enumeration, Text = $" Weaving: Textiles, baskets, and rugs" };
            yield return new TextBlock { Id = Guid.Parse("f7e66106-95b0-4723-bd9c-6605ac97141b"), Type = TextBlockType.Enumeration, Text = $" Woodworking: Wooden goods and structures" };
            yield return new TextBlock { Id = Guid.Parse("e98343dc-ad28-4649-b963-945a138d4a75"), Type = TextBlockType.Text, Text = $"You must have the {ToMarkdownLink<Models.Entities.Feat>("Alchemical Crafting", Feats.Instances.AlchemicalCrafting.ID)} skill feat to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} alchemical items." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e66463e6-f3ad-4046-9baa-deaeb0ee1cb2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7beff55-04da-4f56-9de3-2637b2172834"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
