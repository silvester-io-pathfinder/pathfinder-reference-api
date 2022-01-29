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
    public class CraneFlutter : Template
    {
        public static readonly Guid ID = Guid.Parse("3380e8a2-21cb-47c5-8060-9b82ec6f572e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crane Flutter",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are targeted with a melee attack by an attacker you can see.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5648cca7-9ab5-4b7f-81d2-13184061a399"), Type = TextBlockType.Text, Text = $"You interpose your arm between yourself and your opponent. Your circumstance bonus to AC from {ToMarkdownLink<Models.Entities.Feat>("Crane Stance", Feats.Instances.CraneStance.ID)} increases to +3 against the triggering attack. If the attack misses you, you can immediately make a crane wing {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the attacker at a -2 penalty, even if the attacker isn't within your reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("407ec0b8-cfa9-4b97-9fc1-cac670b6105d"), Feats.Instances.CraneStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd5062ca-28d3-465d-bb23-eacb325ef5f3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
