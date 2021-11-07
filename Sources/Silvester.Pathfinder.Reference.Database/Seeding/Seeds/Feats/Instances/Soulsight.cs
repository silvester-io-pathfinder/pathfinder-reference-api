using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Soulsight : Template
    {
        public static readonly Guid ID = Guid.Parse("9c5a77c0-510c-432e-aa97-26087656d3a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soulsight",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bff130e3-0a5e-446b-9fd1-90bd29d357b6"), Type = TextBlockType.Text, Text = "The spiritual essence in your blood has opened your senses to the world beyond. You gain spiritsense as an imprecise sense with a range of 60 feet. Spiritsense allows you to sense the spirits of creatures within the listed range, including living creatures, most non-mindless undead, and haunts. As with your hearing and other imprecise senses, you still need to (action: Seek) to locate an undetected creature. As spiritsense detects spiritual essence, not physical bodies, it can detect spirits projected by spells such as (spell: project image) or possessing otherwise soulless objects. It can’t detect soulless bodies, constructs, or objects, and like most senses, it doesn’t penetrate through solid objects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("2334c720-0f7f-442a-a065-249fa8dc364e"), "Bloodline that grants divine or occult spells.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adb72a8f-6eb6-4889-8f2c-e622cd4e4eeb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
