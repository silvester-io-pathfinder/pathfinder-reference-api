using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("1be77782-3309-4f0a-9af7-f85bafa30b79");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heal Companion",
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
            yield return new TextBlock { Id = Guid.Parse("87801676-5d4c-456b-b2b3-a593f1dcda2b"), Type = TextBlockType.Text, Text = $"You have a deep devotion to your animal companion that enables you to magically heal their wounds. You gain the {ToMarkdownLink<Models.Entities.Spell>("heal companion", Spells.Instances.HealCompanion.ID)} warden spell and a focus pool of 1 Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyAnimalCompanion(Guid.Parse("71f70ac0-b0fb-4a3f-b6da-4ac0cb49d8dc"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3362daeb-6b41-4784-bed2-415225dc98b9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
