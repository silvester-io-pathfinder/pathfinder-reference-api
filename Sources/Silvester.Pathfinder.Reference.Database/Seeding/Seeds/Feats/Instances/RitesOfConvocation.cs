using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RitesOfConvocation : Template
    {
        public static readonly Guid ID = Guid.Parse("54ab5957-f816-42f8-be8c-92f066de4acc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rites of Convocation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b127a720-8e2d-4f9b-bac6-3ae56bdcd3e1"), Type = TextBlockType.Text, Text = "Your patron grants you the power to summon other creatures to aid you. Choose one summon spell (such as (spell: summon animal), (spell: summon construct), and so forth) that appears on the spell list of your spellcasting tradition. You can spend 10 minutes in communion with your familiar to replace one spell you’ve prepared in one of your witch spell slots with the spell you chose, heightened to the same level. The spell you replaced must be of at least the summon spell’s minimum spell level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3bf9ca0b-6798-4b89-852c-9c31941b88ea"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
