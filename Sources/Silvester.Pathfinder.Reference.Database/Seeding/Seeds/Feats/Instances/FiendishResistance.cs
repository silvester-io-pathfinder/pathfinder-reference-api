using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FiendishResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("81747f19-34a5-46f2-80da-562e6d6f690b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Resistance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6d9e26a-b6cc-4f97-9148-4ebb9533fdfc"), Type = TextBlockType.Text, Text = "Your connection to your fiendish forebears has granted you one of their resistances as well. Choose one of the following energy damage types: acid, cold, electricity, fire, or sonic. You gain resistance 5 to that damage type." };
            yield return new TextBlock { Id = Guid.Parse("41cfe169-c6fd-47ae-a31c-c956319100b8"), Type = TextBlockType.Text, Text = "Though you can choose any of these, the damage type typically matches a fiend associated with your bloodline. For instance, a hellspawn might choose resistance to fire, or a pitborn with a vrock ancestor might choose resistance to electricity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74c43c7e-55dd-4dcd-84b5-22a0f803b163"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
