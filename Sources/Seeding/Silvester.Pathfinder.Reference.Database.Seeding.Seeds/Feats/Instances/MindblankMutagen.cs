using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MindblankMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("f7d95618-bee1-4595-a260-2bf6e6412c21");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mindblank Mutagen",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9dfbf869-981b-4d72-9239-08cb42b2a8bb"), Type = TextBlockType.Text, Text = $"With a minor adjustment of ratios in the formula for your serene mutagen, you gain mental protections. When you're affected by a serene mutagen, detection, revelation, and scrying effects of 9th level or lower detect nothing from you or your possessions and auras. For instance, {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)} would still detect other magic in the area, but not any magic on you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28dddc4a-fa78-451f-a212-fd578655b310"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
