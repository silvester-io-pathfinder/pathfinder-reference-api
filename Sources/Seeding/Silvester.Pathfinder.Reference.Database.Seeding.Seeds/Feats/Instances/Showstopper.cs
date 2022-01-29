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
    public class Showstopper : Template
    {
        public static readonly Guid ID = Guid.Parse("19a89f12-c702-455d-a028-3f38a40b1e8b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Showstopper",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47eef16c-cc43-48a3-b839-852c0c8e747b"), Type = TextBlockType.Text, Text = $"Your twirling weapons create a grand distraction that's difficult to look away from. When using {ToMarkdownLink<Models.Entities.Feat>("Pistol Twirl", Feats.Instances.PistolTwirl.ID)} to {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)}, you can target all enemies within your weapon's first range increment who you can perceive and who can see you. You roll one Deception check and compare it against each target's Perception DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("edbea644-4356-4d24-b567-1679b2da05d7"), Feats.Instances.PistolTwirl.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("638c3c5d-42b0-4c0f-a631-2b38211e1add"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70cc099e-fb39-4b1b-b593-6b75b904789d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
