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
    public class VikingDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ad9e0631-a502-4d6f-a3b1-a0bfb9f1af99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the viking archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30df0cae-a1e9-4591-9057-a55fa19420f0"), Type = TextBlockType.Text, Text = $"Vikings spend long periods of time at sea, only to leap from their boats at a moment's notice, charge through the surf, and take their enemies by storm. You're trained in Sailing Lore. When moving through water using your land Speed, you ignore difficult terrain resulting from shallow water, such as in bogs or on beaches. In addition, if you roll a success for your Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)}, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("88dadf27-790c-421a-869b-669e3a9382ab"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0665f2f2-0e6e-42e6-859b-6451c7e5f4b6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
