using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RetainAbsorbedSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("5032b748-241b-46e9-b396-7e773eed8c82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Retain Absorbed Spell",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6013acb0-4c2c-486e-8f00-53ff05b3e051"), Type = TextBlockType.Text, Text = "When you absorb a spell using the (feat: Absorb Spell) reaction, you utilize secret, techniques that allow you to retain the power and knowledge necessary to cast the spell repeatedly – potentially for a greater period of time. If you&#39;re a spontaneous caster, you can cast the triggering spell up to three times instead of once. If you&#39;re a prepared spellcaster, you can replace up to three of your prepared spells of the same level with the absorbed spell instead of one. Either way, you can choose to retain the absorbed spell for the next hour instead of the next 10 minutes; if you choose to extend the absorption to an hour, you can&#39;t use (feat: Absorb Spell) again until one hour after the spell is absorbed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4154950c-2ea9-4bbb-86db-145f97099a50"), Feats.Instances.AbsorbSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d512d43-bdb0-4814-af14-d714440b7ff1"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
