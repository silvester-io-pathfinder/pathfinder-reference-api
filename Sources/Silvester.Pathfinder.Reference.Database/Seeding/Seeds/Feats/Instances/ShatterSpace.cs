using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShatterSpace : Template
    {
        public static readonly Guid ID = Guid.Parse("f91d141d-56a9-46b9-9a8e-3b167e6359ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shatter Space",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f433464a-63cd-4a90-83e0-c89cc75a9fcc"), Type = TextBlockType.Text, Text = "The sheer power of your psychic magic causes fractures in reality. Use this amp in place of the psi cantrip’s normal amp entry." };
            yield return new TextBlock { Id = Guid.Parse("ce5a8fa0-5b55-4419-95a3-963a01d01942"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("d654cdb4-2321-4f5a-b51d-e379d29ad9ec"), Type = TextBlockType.Text, Text = "~ Amp: You or one target of the spell are surrounded in a spiral of torn space. This is an aura in a 5-foot emanation. A creature that starts its turn in the aura takes 1d6 slashing damage for every 2 levels of the amped psi cantrip, with a basic Reflex save against your spell DC. The aura lasts until the beginning of your next turn. You can choose whether the aura affects the creature emitting it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfd40763-6d49-454c-a450-0b4dad724426"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
