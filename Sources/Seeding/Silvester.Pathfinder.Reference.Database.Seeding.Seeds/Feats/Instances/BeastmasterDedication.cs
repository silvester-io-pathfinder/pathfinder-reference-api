using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2dfa42f8-49db-4e4c-a43c-890eb32e371b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beastmaster Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the beastmaster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54a8d3c8-ac8c-4ec8-af0b-155a2b249ac0"), Type = TextBlockType.Text, Text = $"You gain the service of a young animal companion that travels with you and obeys your commands. The rules for animal companions appear on page 214. Contrary to the usual rules for animal companions, this feat can grant you a second animal companion. If you ever have more than one animal companion, you gain the {ToMarkdownLink<Models.Entities.Feat>("Call Companion", Feats.Instances.CallCompanion.ID)} action." };
            yield return new TextBlock { Id = Guid.Parse("c45811b5-505f-40c4-a55b-f79dbfb4af9d"), Type = TextBlockType.Text, Text = $"Certain beastmaster feats give you primal focus spells. The rules for focus spells appear on page 300. When you gain your first beastmaster focus spell, you become trained in primal spell attack rolls and spell DCs, and your spellcasting ability for these spells is Charisma. Feats that grant beastmaster focus spells tell you to increase the number of Focus Points in your pool, but if you don't already have a focus pool, you instead get a focus pool with 1 Focus Point. You can {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} by grooming, feeding, playing with, or otherwise tending to an animal companion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b18eeb19-8f89-4fdf-8dc4-9bfe4a4f28c2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4679757f-5486-41b9-8371-f6e6e7d5d876"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
