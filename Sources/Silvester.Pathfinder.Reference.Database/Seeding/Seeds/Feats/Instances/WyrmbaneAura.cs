using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WyrmbaneAura : Template
    {
        public static readonly Guid ID = Guid.Parse("0186a8da-46e2-414d-9371-8439fa487f11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wyrmbane Aura",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52a03ccb-fdd2-467a-8003-26f268a674dd"), Type = TextBlockType.Text, Text = "Your aura protects against destructive energies and dragons’ breath. You and all allies within 15 feet gain resistance equal to your Charisma modifier to acid, cold, electricity, fire, and poison. If the source of one of these types of damage is a dragon’s breath, increase the resistance to half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("34a1c5ec-2c97-4ad2-9754-d753ceedf866"), Feats.Instances.VengefulOath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06f02d5e-30e3-4554-854e-5d51a48abf25"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
