using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cruelty : Template
    {
        public static readonly Guid ID = Guid.Parse("4c236ac2-a142-497e-8b4a-d5b3207a3441");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cruelty",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c55adac-ceed-474f-995a-5de4a0822251"), Type = TextBlockType.Text, Text = $"The harm you deal with your corrupting touch saps the strength from your enemy's body. If your next action is to cast {ToMarkdownLink<Models.Entities.Spell>("touch of corruption", Spells.Instances.TouchOfCorruption.ID)} on a living creature, the target is also enfeebled 1 for 1 minute if it fails its save (enfeebled 2 if it critically fails)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("4d2fefb0-aeaf-4cc8-9e8a-5c892dfdae50"), Spells.Instances.TouchOfCorruption.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5cc77fd-ba5a-456e-80e2-d772dbe9288d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
