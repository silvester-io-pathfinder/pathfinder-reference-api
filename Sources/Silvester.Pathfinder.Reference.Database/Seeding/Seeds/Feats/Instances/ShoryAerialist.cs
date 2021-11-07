using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShoryAerialist : Template
    {
        public static readonly Guid ID = Guid.Parse("ca66fa45-a207-4ad1-8265-a0e8210b20d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shory Aerialist",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b924961-3338-4169-aed1-c5e5b8d25d46"), Type = TextBlockType.Text, Text = "~ Access: Garundi, Mauxi, or Tian-Yae ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("b930bfec-341d-4329-a34b-313a98bb4ad6"), Type = TextBlockType.Text, Text = "Unique in Golarion’s history, the Shory people developed fighting styles dedicated to combat in the air. You gain a +2 circumstance bonus to Acrobatics checks to (action: Maneuver in Flight) and a +5-foot status bonus to your fly Speed whenever you are flying via magic." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("cf7298dc-a78c-4882-87c5-350f585efe7d"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("dc1869bf-9f61-4539-be78-d234c0314204"), Feats.Instances.ShoryAeromancer.ID);
                or.HaveSpecificSpell(Guid.Parse("7e21d6fe-e21f-49f7-a1ab-47ff348e4324"), Spells.Instances.Fly.ID);
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
                Id = Guid.Parse("77726460-a55c-4493-b4f9-c64be95cc939"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
