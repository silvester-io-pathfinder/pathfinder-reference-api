using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ContingencyGadgets : Template
    {
        public static readonly Guid ID = Guid.Parse("960a0724-e5a4-4122-ab0d-c24bf82660f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Contingency Gadgets",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c29145c-a193-4997-9ada-121399d7dbef"), Type = TextBlockType.Text, Text = "You are too brilliant to be caught off guard, and you always have just the right gadget for the situation. When you prepare your gadgets during your daily preparations, you can choose to leave one of them as a contingency gadget that you keep ready for just this situation, rather than declaring which gadget you’re making. You can pull the contingency gadget out using an (action: Interact) action, at which point you must choose which gadget you had prepared as a contingency." };
            yield return new TextBlock { Id = Guid.Parse("15a2416e-cfa2-481d-9f2e-643093a8fadd"), Type = TextBlockType.Text, Text = "If you’re legendary in Crafting, you can leave two contingency gadgets during your daily preparations, instead of just one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("190566dd-092d-41fa-b789-8febb637ccfe"), Feats.Instances.GadgetSpecialist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("059e3aa2-9196-4e6d-886e-58d292801e74"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
