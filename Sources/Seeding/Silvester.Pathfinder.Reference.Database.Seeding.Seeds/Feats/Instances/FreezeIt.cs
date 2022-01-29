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
    public class FreezeIt : Template
    {
        public static readonly Guid ID = Guid.Parse("4af0e1c6-293f-4d24-809a-7a9e904d581a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Freeze It!",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d501680-cb7a-4c3f-801f-a450c4dc8990"), Type = TextBlockType.Text, Text = $"You are no rime hag or Jadwiga, but the magic of the north has still left a mark on you. Frigid ice runs through your veins, and you can expel frost from your body to freeze your foes. Attempt an Athletics check against the Fortitude DC of an adjacent foe." };
            yield return new TextBlock { Id = Guid.Parse("5c9bffe4-b194-4ef2-a8e3-9461665683cf"), Type = TextBlockType.Text, Text = $"If you have master proficiency in Athletics, you can affect up to two adjacent foes, rolling one Athletics check against each foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("84cce0a7-966c-47c9-a516-e002e64f4cb9"), Heritages.Instances.SnowGoblin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d90e627b-60f1-48e6-afe6-b89729a8c2d7"), Traits.Instances.Goblin.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0c09270c-55bb-4923-bf3d-a4267902d230"),
                CriticalSuccess = "The target becomes clumsy 2 for 1 round.",
                Success = "The target becomes clumsy 1 for 1 round.",
                
                CriticalFailure = "The target is temporarily immune for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16404e4f-47c9-4d00-9e95-f037b45e5bf4"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
