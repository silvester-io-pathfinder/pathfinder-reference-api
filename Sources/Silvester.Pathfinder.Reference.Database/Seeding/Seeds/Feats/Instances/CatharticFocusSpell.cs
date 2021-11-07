using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatharticFocusSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("a67bb62b-45b2-4c88-bd1d-32fa1913756f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cathartic Focus Spell",
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
            yield return new TextBlock { Id = Guid.Parse("87c0574f-8ae4-472c-a03f-85022afd9041"), Type = TextBlockType.Text, Text = "You learn the focus spell listed under your emotion’s entry. You can cast it only while in emotional fervor. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) while you use (feat: Settle Emotions)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2fc177e5-a8b0-470d-b041-96735564dc43"), Feats.Instances.CatharticMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56e37048-f5e6-46bb-b3d3-4426298fb605"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
