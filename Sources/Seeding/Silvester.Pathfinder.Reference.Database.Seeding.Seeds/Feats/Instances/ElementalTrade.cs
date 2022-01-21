using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalTrade : Template
    {
        public static readonly Guid ID = Guid.Parse("baaaf735-0070-489e-905e-b776fd33d8c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Trade",
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
            yield return new TextBlock { Id = Guid.Parse("d211908e-e313-409f-9940-eebf2e1ffc7a"), Type = TextBlockType.Text, Text = $"You have a strong connection with stone and metal. You gain the trained proficiency rank in Crafting. If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. You gain the {ToMarkdownLink<Models.Entities.Feat>("Specialty Crafting", Feats.Instances.SpecialtyCrafting.ID)} skill feat for both Stonemasonry and Blacksmithing." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b46e2dad-9a3b-44e5-9edb-07843d329d81"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
