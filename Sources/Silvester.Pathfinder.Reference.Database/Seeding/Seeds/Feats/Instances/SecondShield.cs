using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecondShield : Template
    {
        public static readonly Guid ID = Guid.Parse("ac134242-3590-4134-bf18-e38d853cc7b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Second Shield",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your Shield Block causes your shield to break or be destroyed.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("062d096b-8adc-48c6-a99f-037bab1c9896"), Type = TextBlockType.Text, Text = "You’re used to your shield breaking in the middle of battle, and you’re prepared to use a backup or any convenient nearby object to defend yourself. You can (action: Interact) to draw a shield on your person or an unattended shield within your reach. If there is an object within your reach that could serve as an improvised shield – for example, a table or chair – you can (action: Interact) to draw it with this feat. The GM determines if something can be used as an improvised shield. Your new shield isn’t raised until you use the (action: Raise a Shield) action, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("df8b09ee-892e-45a0-86f9-5938aa6dd03e"), Feats.Instances.VikingDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("34a8c47c-ddfd-4a3d-9e6c-f5856dbe8e8c"), Feats.Instances.ShieldBlock.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b487505-9a20-4a93-ae7b-a638c2e4dfdc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
