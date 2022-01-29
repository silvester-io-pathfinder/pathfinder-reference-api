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
    public class AdvantageousAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("9e2ea9ac-1f74-46c2-a59e-de41b238cfa1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advantageous Assault",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f1e1b69-a648-4ba6-b584-f9ba5b18bb08"), Type = TextBlockType.Text, Text = $"When an enemy's movement is compromised, you deliver a more deadly blow. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a creature that is grabbed, prone, or restrained. You gain a circumstance bonus to damage on this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} equal to the number of weapon damage dice, or that number + 2 if you're wielding the weapon in two hands. The {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} gains the following failure effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0405a386-72ce-460c-aba2-76c4ea712740"),
                
                
                Failure = "You deal damage to the target equal to the number of weapon damage dice, or that number + 2 if you're wielding the weapon in two hands. This damage has the same damage type as the weapon.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4c1a931-c653-4a15-a6d6-17d1d0f9c1f4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
