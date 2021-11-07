using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VileDesecration : Template
    {
        public static readonly Guid ID = Guid.Parse("72a3c280-0494-4878-b752-dae092cd3919");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vile Desecration",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05286b12-37f3-407f-b42e-f7dbda20a6cc"), Type = TextBlockType.Text, Text = "You combine unholy might with negative energy to damage angels, archons, and other self-righteous denizens of the Outer Planes. When you cast a (spell: harm) spell, you can change the damage you deal to celestial creatures to evil damage instead of negative damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("88fa2dd5-3fd3-44b9-ba91-10082ea54337"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("f00aef0f-7391-4f57-aed6-ff632dc6edd9"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("a554ba66-6d03-4f56-b0fa-2c8cd813da4a"), Alignments.Instances.NeutralEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("e51dded4-f8fc-4070-88b5-02473dbef1e3"), Alignments.Instances.ChaoticEvil.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acfb2884-9c32-41d6-a42e-8cc65ed98abd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
