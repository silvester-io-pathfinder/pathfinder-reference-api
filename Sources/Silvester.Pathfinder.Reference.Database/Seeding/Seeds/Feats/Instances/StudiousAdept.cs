using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudiousAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("2fe3c8a7-fb20-42a3-aa40-f707bf1ecfad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Studious Adept",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad334194-6b5d-4993-a366-5184c10c3b09"), Type = TextBlockType.Text, Text = "You achieve a breakthrough in your exploration of magic. You gain (spell: humanoid form) and (spell: mirror image) as 2nd-level arcane innate spells. You can cast each of these arcane innate spells once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("71203c29-ebf6-4550-b0aa-6eeac06c97f2"), Feats.Instances.StudiousMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5134d6e4-4b8f-459e-908f-591adf507438"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
