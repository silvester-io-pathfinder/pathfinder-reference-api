using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationRazorProngs : Template
    {
        public static readonly Guid ID = Guid.Parse("6b8acfe5-8062-4f21-bc95-403ff61c98ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Razor Prongs",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76504814-9a67-4061-acc0-90a1ed58d324"), Type = TextBlockType.Enumeration, Text = "*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("6e02322d-e3b9-4d62-b92d-5a154b7e7c93"), Type = TextBlockType.Text, Text = "You can knock down and slash your foes with sharp, curved blades added to your weapon. Your innovation gains the (trait: trip) and (trait: versatile S) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4aaf953e-a777-4d31-b710-d1ff129a4df8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
