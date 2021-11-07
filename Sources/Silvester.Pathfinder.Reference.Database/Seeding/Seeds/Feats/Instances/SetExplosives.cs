using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SetExplosives : Template
    {
        public static readonly Guid ID = Guid.Parse("0a448391-1e8f-44d0-afca-47ed12c3515c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Set Explosives",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05853111-4ee5-4b01-82a4-b88bc3702923"), Type = TextBlockType.Text, Text = "You attach the bombs to an inanimate object within your reach, such as a door, wall, or column, and rig them to detonate at a set time. The bombs explode at a specific time you determine (such as after your next action or at the start of your next turn, to a maximum of 1 minute), dealing their damage and splash damage to the inanimate object. Combine this damage for the purpose of resistances and weaknesses, and this damage ignores an amount of the object’s Hardness equal to your level. Any creatures adjacent to the hazard take the bombs’ splash damage, also combined for the purpose of resistances and weaknesses. As a reminder, since you didn’t throw the bombs, (feat: Calculated Splash) and similar effects don’t apply. Making sure your timing is correct requires concentration, so you can’t Set Explosives again while you’re waiting for a previously set bomb to detonate." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6fb9778-78e6-4a11-8ccd-7fc50e223575"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
