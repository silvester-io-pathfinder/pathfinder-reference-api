using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationEntanglingForm : Template
    {
        public static readonly Guid ID = Guid.Parse("0f706f4c-cd1d-48b8-8c2a-261ff3798cc2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Entangling Form",
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
            yield return new TextBlock { Id = Guid.Parse("a00f4dc8-c5a7-4fc5-b58d-da783bd16192"), Type = TextBlockType.Enumeration, Text = "*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("c7c983f6-5aea-41e2-b7ff-72f9bfaf1c88"), Type = TextBlockType.Text, Text = "You’ve altered your weapon to including tangling wires or straps, or to have a flexible construction. Your innovation gains the (trait: grapple) and (trait: trip) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df9b53f3-cf1e-43ee-9646-e25a8895f0e4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
