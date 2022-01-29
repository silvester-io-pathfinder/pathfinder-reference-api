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
    public class BlastLock : Template
    {
        public static readonly Guid ID = Guid.Parse("4a0297f7-e3a3-4eb4-b230-54d547e25115");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blast Lock",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1eaf788e-62cf-4783-bc67-5948437863ee"), Type = TextBlockType.Text, Text = $"Sometimes taking the shortest distance between two points involves removing an obstacle or two. You shoot your firearm at a lock within 10 feet. Make an attack roll against the DC required to {ToMarkdownLink<Models.Entities.SkillAction>("Pick the Lock", SkillActions.Instances.PickALock.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("038a672e-97fb-4abf-9f62-4626ae26fabe"),
                CriticalSuccess = "You open the lock, or you achieve two successes toward opening a complex lock.",
                Success = "You open the lock, or you achieve one success toward opening a complex lock.",
                Failure = "You fail to open the lock, and your shot makes it harder to open. Future attempts to (action: Pick the Lock|Pick a Lock) or Blast the Lock take a –2 circumstance penalty.",
                CriticalFailure = "You fail to open the lock, and your shot makes it much harder to open. Future attempts to (action: Pick the Lock|Pick a Lock) or Blast the Lock take a –4 circumstance penalty.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5799b17-d918-412a-9e2e-1ae29f4a1724"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
