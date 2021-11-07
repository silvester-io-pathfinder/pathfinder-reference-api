using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("6d7fb67d-2e8c-4200-a53f-7adce4885266");

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
            yield return new TextBlock { Id = Guid.Parse("95c553fa-c271-4bf8-95e5-cd3f61ea39e2"), Type = TextBlockType.Text, Text = "You gain the service of a young animal companion that travels with you and obeys your commands. The rules for animal companions appear on page 214. Contrary to the usual rules for animal companions, this feat can grant you a second animal companion. If you ever have more than one animal companion, you gain the (feat: Call Companion) action." };
            yield return new TextBlock { Id = Guid.Parse("4ec2f743-c0ea-4c40-b1ee-a13900f06e1e"), Type = TextBlockType.Text, Text = "Certain beastmaster feats give you primal focus spells. The rules for focus spells appear on page 300. When you gain your first beastmaster focus spell, you become trained in primal spell attack rolls and spell DCs, and your spellcasting ability for these spells is Charisma. Feats that grant beastmaster focus spells tell you to increase the number of Focus Points in your pool, but if you don’t already have a focus pool, you instead get a focus pool with 1 Focus Point. You can (action: Refocus) by grooming, feeding, playing with, or otherwise tending to an animal companion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d213f41b-f06f-4434-9bde-e2e800f025e8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("649d1efa-e8a3-4cb3-a205-a212b822c42b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
