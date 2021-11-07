using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationModularHead : Template
    {
        public static readonly Guid ID = Guid.Parse("69ffc11b-998e-4568-a811-a1d9c7b76fab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Modular Head",
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
            yield return new TextBlock { Id = Guid.Parse("072560de-082c-4c53-ac1f-3085dbeb7b7e"), Type = TextBlockType.Text, Text = "You’ve constructed a multi-purpose, adjustable striking surface for your weapon, or you’ve made special ammunition you can swiftly alter. Your innovation gains the (trait: modular | modular B, P, or S) trait for bludgeoning, piercing, and slashing. When you (action: Interact) to use the (trait: modular) trait, you can also choose to give the weapon the (trait: nonlethal) trait if it doesn’t currently have it, or to remove that trait if it’s currently nonlethal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22a8cdaf-c475-49c9-b4f7-62b9924ee74a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
