using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Remediate : Template
    {
        public static readonly Guid ID = Guid.Parse("14f0b41c-ea45-494f-8791-f1440274e2ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remediate",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9925dc74-4145-4f62-acc7-ad78cbe32ac0"), Type = TextBlockType.Text, Text = "If your next action is to use your divine font to cast a 3-action (spell: heal) or (spell: harm) spell to damage creatures, you can harness the residual energy to counterbalance opposing forces. You use your (spell: heal) or (spell: harm) spell to attempt to counteract one effect in the spell’s area with the chaotic, evil, good, or lawful trait. The chosen trait must oppose one component of your deity’s alignment; if your deity is neutral, you can choose any one trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("8855542d-568e-43c7-b124-8b32139f2e77"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("f56b96ef-d831-4f0e-9367-e2d8c20d821a"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("ccdc0287-2e50-4cdc-9d8c-3e136ab7b68b"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db242b9e-a46b-4923-a152-82a32169ba1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
