using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpontaneousIgnition : Template
    {
        public static readonly Guid ID = Guid.Parse("d88255a8-b344-4872-9bb2-56e570370442");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spontaneous Ignition",
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
            yield return new TextBlock { Id = Guid.Parse("8d427b64-0652-4c5a-b102-042555a202ed"), Type = TextBlockType.Text, Text = "The sheer intensity of your mental focus causes spontaneous combustion. Use this amp in place of the psi cantrip’s normal amp entry. The amped psi cantrip must be one that deals damage and doesn’t have a duration." };
            yield return new TextBlock { Id = Guid.Parse("e972144f-6c7e-4250-a404-98e7698c78e0"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("87e2320d-5ad8-462d-a60d-6dee0cafefa1"), Type = TextBlockType.Text, Text = "~ Amp: Half of any damage dealt by the amped psi cantrip is instead fire damage, and the spell also deals an additional 1 fire damage per spell level. The spell gains the (trait: fire) trait. If the spell deals more than one type of damage, change half the damage of each type to fire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9690df77-078b-44aa-bbba-0593d96f0187"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
