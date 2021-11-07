using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FamiliarsEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("42a12ad0-9038-418b-9fb3-e0f28a92d917");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar's Eyes",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b6ccdae-631f-4111-a798-7929fabdfd66"), Type = TextBlockType.Text, Text = "You use your familiar’s senses as easily as your own. You project your senses into your familiar. When you do, you lose all sensory information from your own body, but you can sense through your familiar’s body until you (action: Dismiss) the effect. While projecting your senses in this way, you can converse telepathically with your familiar if it understands a language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyFamiliar(Guid.Parse("48580be8-a4f9-480d-95ee-c7953b51f290"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b24f38f-85fa-434a-9a9e-c9b128eadf1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
