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
    public class FeatheredCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("a23b200a-c725-483a-b650-a070ee4bde95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feathered Cloak",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a019e2f-7c52-4582-9635-76f2508efe6d"), Type = TextBlockType.Text, Text = $"To blend in with the grounded and wingless, you fold your wings just so on your back, creating the illusion of a feathered cloak. You receive a +2 circumstance bonus to Deception checks to {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} a version of yourself who is not a strix." };
            yield return new TextBlock { Id = Guid.Parse("d2f473e3-a4d3-458e-acc5-d3a55f9c8aa4"), Type = TextBlockType.Text, Text = $"Additionally, your folded wings help you obscure objects on your person, providing a +2 circumstance bonus to Stealth checks to {ToMarkdownLink<Models.Entities.SkillAction>("Conceal an Object", SkillActions.Instances.ConcealAnObject.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b3ae66d-b0a3-43a7-b20c-d7a9d4c959c5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
