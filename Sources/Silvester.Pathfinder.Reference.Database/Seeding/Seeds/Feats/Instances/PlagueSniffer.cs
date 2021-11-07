using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlagueSniffer : Template
    {
        public static readonly Guid ID = Guid.Parse("c0ed5937-a04b-45ce-9c35-f67d1b4c0b5b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plague Sniffer",
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
            yield return new TextBlock { Id = Guid.Parse("cbefc194-298a-44ef-ab4b-870193497059"), Type = TextBlockType.Text, Text = "You can sniff out the pungent tang of disease. When you detect a creature by scent, you can also detect if that creature is suffering from a disease at a non-carrier state. If the disease is particularly subtle, you might need to attempt a Perception check against the disease’s DC (subject to the GM’s discretion)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("e0c6932a-51ac-4ab7-b25e-99e2f27758eb"), Heritages.Instances.LongsnoutRat.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85d87cae-125d-47bc-a230-1627d59daac8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
