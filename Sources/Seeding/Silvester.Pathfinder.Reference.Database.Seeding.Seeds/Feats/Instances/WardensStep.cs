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
    public class WardensStep : Template
    {
        public static readonly Guid ID = Guid.Parse("ca8e7439-cf46-4a47-b1ce-8ec58c4e3591");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warden's Step",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c283c1e7-d784-42b8-8d15-da6a2bb42a62"), Type = TextBlockType.Text, Text = $"You can guide your allies to move quietly through the wilderness. When you {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} during exploration in natural terrain, you can designate any number of your allies to gain the benefits as if they were using that activity during that exploration. This requires no action on their part." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("62fc6559-0401-40ce-9b12-0a90ac49b337"), Feats.Instances.HorizonWalkerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("38ada1dd-c75f-49f4-bce4-c3afb1d90e75"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d28ba393-f1f1-4d5e-a402-9726684e03d3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
