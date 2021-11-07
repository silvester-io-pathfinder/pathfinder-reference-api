using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("f43ca7f3-0262-4baf-8202-e9670fa465ae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Spells",
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
            yield return new TextBlock { Id = Guid.Parse("16310892-d62a-4744-bef7-60882f6c1d8b"), Type = TextBlockType.Text, Text = "Hidden darkness whispers to you, teaching you secrets of shadow beyond other spellcasters of your tradition. Add (spell: shadow blast), (spell: shadow siphon), and (spell: shadow walk) your spell list, as well as (spell: replicate), (spell: shadow army), (spell: shadow projectile), and (spell: shadow raid). You can thus potentially learn these spells even if they aren’t normally on your tradition’s spell list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("05781c9d-f6cd-4520-8699-0fe389dbb262"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("819c8245-3857-4bbd-9270-411399ec69a7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
