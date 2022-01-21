using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies.Instances
{
    public class Empiricism : Template
    {
        public static readonly Guid ID = Guid.Parse("23e0bf1c-001b-4a53-9c4f-d4e59b11185d");
        
        protected override Methodology GetMethodology()
        {
            return new Methodology
            {
                Id = ID, 
                Name = "Empiricism",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cc929382-fe15-44cc-bda3-5a0c3cf7c308"), Type = TextBlockType.Text, Text = "Everything comes down to data. Calculating statistics, running numbers, and using inductive reasoning allows you to determine the most likely outcome of any scenario, and anything out of place draws your keen attention." };
            yield return new TextBlock { Id = Guid.Parse("4074b043-1bb0-49ac-9297-fffa79ca51e4"), Type = TextBlockType.Text, Text = "You are trained in one Intelligence-based skill of your choice. You gain the That�s Odd investigator feat (page 60), and you gain the Expeditious Inspection free action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add the option for the methodology skill.
            builder.GainSpecificStatSkillFeat(Guid.Parse("0805cb05-d355-474a-b511-83bd3dcc8f82"), Guid.Parse("c90e5c80-08ab-449b-8ab0-70d8ccb0955e"), Stats.Instances.Intelligence.ID, requiredLevel: 3);
            builder.GainSpecificStatSkillFeat(Guid.Parse("b3089ad8-d560-411a-bfd2-803486d34c6b"), Guid.Parse("e01a2858-5062-4dfe-a1fd-1e3ef3a07a57"), Stats.Instances.Intelligence.ID, requiredLevel: 5);
            builder.GainSpecificStatSkillFeat(Guid.Parse("dd457b96-b24f-4651-876e-d3ead036f9e6"), Guid.Parse("01105bec-89b4-43c0-8449-c612e3a43b36"), Stats.Instances.Intelligence.ID, requiredLevel: 7);
            builder.GainSpecificStatSkillFeat(Guid.Parse("a8cfab6b-876c-46dc-9927-e90c18c64072"), Guid.Parse("a552d9e9-2927-41d4-9bd9-72ba88b213b3"), Stats.Instances.Intelligence.ID, requiredLevel: 9);
            builder.GainSpecificStatSkillFeat(Guid.Parse("e9e45276-8aa4-4f71-ae5a-a699e107d8b0"), Guid.Parse("b7734e24-75d2-4307-8baa-bc98e5f96305"), Stats.Instances.Intelligence.ID, requiredLevel: 11);
            builder.GainSpecificStatSkillFeat(Guid.Parse("ff4a3698-1119-4caf-8962-f00743709d6d"), Guid.Parse("4e4345ad-2884-4ddd-9a99-d89e4240f19a"), Stats.Instances.Intelligence.ID, requiredLevel: 13);
            builder.GainSpecificStatSkillFeat(Guid.Parse("0fa210a8-1042-432a-8c26-ec61dad72e17"), Guid.Parse("89146d66-073d-404a-8e95-fb2a87c62442"), Stats.Instances.Intelligence.ID, requiredLevel: 15);
            builder.GainSpecificStatSkillFeat(Guid.Parse("3172185a-7fe7-42c6-b006-5d77222caaf0"), Guid.Parse("c5cfb366-d02c-4db6-8005-63c42061b9c7"), Stats.Instances.Intelligence.ID, requiredLevel: 17);
            builder.GainSpecificStatSkillFeat(Guid.Parse("c40f4676-8218-40a3-ac82-21eaebc3cea9"), Guid.Parse("1d1cd8e3-9c39-42f3-bd9f-47c68340703b"), Stats.Instances.Intelligence.ID, requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a5410db-2a94-4e5a-91fc-07aef1af056b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
