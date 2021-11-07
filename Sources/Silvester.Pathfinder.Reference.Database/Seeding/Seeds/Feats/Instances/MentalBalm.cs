using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MentalBalm : Template
    {
        public static readonly Guid ID = Guid.Parse("cc616712-46da-4e15-8375-edb6d70f959e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mental Balm",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30b38e95-c9b0-4ff0-b209-0c1859c4e3a5"), Type = TextBlockType.Text, Text = "As your psychic magic flares, you release soothing mental waves to stabilize the mind. Use this amp in place of the psi cantrip’s normal amp entry. You can use this amp only on a psi cantrip that targets or affects one or more of your allies and doesn’t target or affect any enemies." };
            yield return new TextBlock { Id = Guid.Parse("b6d300d2-24bf-46d5-a40a-01fe809b3dc7"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("16e24612-0c68-4da6-be1a-e96baaec3a3f"), Type = TextBlockType.Text, Text = "~ Amp: You or one ally within 30 feet gain a +1 bonus to Will saves against (trait: emotion) effects for 1 round. You can also have the amped psi cantrip attempt to counteract one effect on yourself or the chosen ally imposing the frightened condition, or an effect imposing the stupefied condition that has a duration of 1 hour or less. On a success, you end the frightened and stupefied conditions, but you don’t end any other parts of the effect, if any." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cecd57f-9d5c-44f7-ab1e-678da0eb6dd3"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
