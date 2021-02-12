using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class DeitySeeder : IEntitySeeder<Deity>
    {
        public IEnumerable<Deity> GetSeedEntities()
        {
            yield return new Deity { Id = Guid.Parse("eda61d79-9877-483f-b660-bc282d270bb6"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Abadar" };
            yield return new Deity { Id = Guid.Parse("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("54f32060-3da3-4edf-b6dc-3839b8b7415d"), Name = "Asmodeus" };
            yield return new Deity { Id = Guid.Parse("88e528a7-7a02-4151-a5f0-23e64e68916f"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2ad80bbd-a735-4431-9e3a-f784e053b756"), Name = "Calistria" };
            yield return new Deity { Id = Guid.Parse("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("add12009-9c8a-4287-b02b-7e5b9459bf44"), Name = "Cayden Cailean" };
            yield return new Deity { Id = Guid.Parse("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("add12009-9c8a-4287-b02b-7e5b9459bf44"), Name = "Desna" };
            yield return new Deity { Id = Guid.Parse("de85224c-6a69-482c-8a8d-dea0c4667e81"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Erastil" };
            yield return new Deity { Id = Guid.Parse("21794a2c-45f8-404a-9ecb-8897571f6c15"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2ad80bbd-a735-4431-9e3a-f784e053b756"), Name = "Gorum" };
            yield return new Deity { Id = Guid.Parse("196494f4-f104-45ad-8216-2c8bf68d3943"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Gozreh" };
            yield return new Deity { Id = Guid.Parse("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Iomedae" };
            yield return new Deity { Id = Guid.Parse("980a89b8-bd72-4434-a744-10cdc645cee6"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Irori" };
            yield return new Deity { Id = Guid.Parse("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("25f9299a-9a7c-40bc-b8bd-58588d19381b"), Name = "Lamashtu" };
            yield return new Deity { Id = Guid.Parse("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Nethys" };
            yield return new Deity { Id = Guid.Parse("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), Name = "Norgorber" };
            yield return new Deity { Id = Guid.Parse("01777837-1255-4d6a-9301-96dc48fffee4"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Pharasma" };
            yield return new Deity { Id = Guid.Parse("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("25f9299a-9a7c-40bc-b8bd-58588d19381b"), Name = "Rovagug" };
            yield return new Deity { Id = Guid.Parse("c624bf0e-d22c-4e01-8691-041083462102"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), Name = "Sarenrae" };
            yield return new Deity { Id = Guid.Parse("f5f38a92-1302-4d45-adf8-38452dde188b"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), Name = "Shelyn" };
            yield return new Deity { Id = Guid.Parse("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Torag" };
            yield return new Deity { Id = Guid.Parse("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), Name = "Urgathoa" };
            yield return new Deity { Id = Guid.Parse("4fec4b99-9934-4872-993a-aec20fcf47e1"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("54f32060-3da3-4edf-b6dc-3839b8b7415d"), Name = "Zon-Kuthon" };
        }
    }

    public class DeityFollowerAlignmentJoiner : IEntityJoiner<Deity, Alignment, DeityFollowerAlignment>
    {
        public DeityFollowerAlignment[] Join(Deity deity, Alignment[] alignments)
        {
            return deity.Name switch
            {
                "Abadar" => Filter(deity, alignments, "Lawful Good", "Lawful Neutral" , "Lawful Evil"),
                "Asmodeus" => Filter(deity, alignments, "Lawful Evil"),
                "Calistria" => Filter(deity, alignments, "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"),
                "Cayden Cailean" => Filter(deity, alignments, "Neutral Good", "Chaotic Good", "Chaotic Neutral"),
                "Desna" => Filter(deity, alignments, "Neutral Good", "Chaotic Good", "Chaotic Neutral"),
                "Erastil" => Filter(deity, alignments, "Lawful Good", "Neutral Good", "Lawful Neutral"),
                "Gorum" => Filter(deity, alignments, "Chaotic Neutral", "Chaotic Evil"),
                "Gozreh" => Filter(deity, alignments, "Neutral Good", "Lawful Neutral", "True Neutral", "Chaotic Neutral", "Neutral Evil"),
                "Iomedae" => Filter(deity, alignments, "Lawful Good", "Neutral Good"),
                "Irori" => Filter(deity, alignments, "Lawful Good", "Lawful Neutral", "Lawful Evil"),
                "Lamashtu" => Filter(deity, alignments, "Chaotic Evil"),
                "Nethys" => Filter(deity, alignments, "Neutral Good", "Lawful Neutral", "True Neutral", "Chaotic Neutral", "Neutral Evil"),
                "Norgorber" => Filter(deity, alignments, "True Neutral", "Lawful Evil", "Neutral Evil", "Chaotic Evil"),
                "Pharasma" => Filter(deity, alignments, "Neutral Good", "Lawful Neutral", "True Neutral"),
                "Rovagug" => Filter(deity, alignments, "Neutral Evil", "Chaotic Evil"),
                "Sarenrae" => Filter(deity, alignments, "Lawful Good", "Neutral Good", "Chaotic Good"),
                "Shelyn" => Filter(deity, alignments, "Lawful Good", "Neutral Good", "Chaotic Good"),
                "Torag" => Filter(deity, alignments, "Lawful Good", "Lawful Neutral"),
                "Urgathoa" => Filter(deity, alignments, "Lawful Evil", "Neutral Evil", "Chaotic Evil"),
                "Zon-Kuthon" => Filter(deity, alignments, "Lawful Neutral", "Lawful Evil", "Neutral Evil"),
                _ => Array.Empty<DeityFollowerAlignment>()
            };
        }

        private static Guid InitialGuid = Guid.Parse("2052eb18-4c69-45ae-aa91-b9b027a02814");

        private static DeityFollowerAlignment[] Filter(Deity deity, Alignment[] alignments, params string[] alignmentNames)
        {
            DeityFollowerAlignment[] matches = alignments
                .Where(alignment => alignmentNames.Contains(alignment.Name))
                .Select(alignment => CreateJoin(deity, alignment))
                .ToArray();

            return matches.Length == alignmentNames.Length
                ? matches
                : throw new InvalidOperationException($"Not all alignment names could be found: {string.Join(", ", matches.Select(e => e.Alignment.Name).GetMissing(alignmentNames))}.");
        }

        private static DeityFollowerAlignment CreateJoin(Deity deity, Alignment alignment)
        {
            InitialGuid = InitialGuid.Increment();
            return new DeityFollowerAlignment { Id = InitialGuid, AlignmentId = alignment.Id, DeityId = deity.Id };
        }
    }

    public class DeityDivineFontJoiner : IEntityJoiner<Deity, DivineFont>
    {
        public DivineFont[] Join(Deity deity, DivineFont[] fonts)
        {
            return deity.Name switch
            {
                "Abadar" => Filter(fonts, "Harm", "Heal"),
                "Asmodeus" => Filter(fonts, "Harm"),
                "Calistria" => Filter(fonts, "Harm", "Heal"),
                "Cayden Cailean" => Filter(fonts, "Heal"),
                "Desna" => Filter(fonts, "Heal"),
                "Erastil" => Filter(fonts, "Heal"),
                "Gorum" => Filter(fonts, "Harm", "Heal"),
                "Gozreh" => Filter(fonts, "Heal"),
                "Iomedae" => Filter(fonts, "Heal"),
                "Irori" => Filter(fonts, "Harm", "Heal"),
                "Lamashtu" => Filter(fonts, "Harm", "Heal"),
                "Nethys" => Filter(fonts, "Harm", "Heal"),
                "Norgorber" => Filter(fonts, "Harm"),
                "Pharasma" => Filter(fonts, "Heal"),
                "Rovagug" => Filter(fonts, "Harm"),
                "Sarenrae" => Filter(fonts, "Heal"),
                "Shelyn" => Filter(fonts, "Heal"),
                "Torag" => Filter(fonts, "Heal"),
                "Urgathoa" => Filter(fonts, "Harm"),
                "Zon-Kuthon" => Filter(fonts, "Harm"),
                _ => Array.Empty<DivineFont>()
            };
        }

        private static DivineFont[] Filter(DivineFont[] fonts, params string[] fontNames)
        {
            DivineFont[] matches = fonts
                .Where(domain => fontNames.Contains(domain.Name))
                .ToArray();

            return matches.Length == fontNames.Length
                ? matches
                : throw new InvalidOperationException($"Not all font names could be found: {string.Join(", ", matches.Select(e => e.Name).GetMissing(fontNames))}.");
        }
    }

    public class DeityDomainJoiner : IEntityJoiner<Deity, Domain>
    {
        public Domain[] Join(Deity deity, Domain[] fonts)
        {
            return deity.Name switch
            {
                "Abadar" => Filter(fonts, "Cities", "Duty","Earth", "Travel", "Wealth"),
                "Asmodeus" => Filter(fonts, "Confidence", "Duty", "Fire", "Glyph", "Trickery", "Tyranny"),
                "Calistria" => Filter(fonts, "Pain", "Passion", "Secrecy", "Trickery"),
                "Cayden Cailean" => Filter(fonts, "Cities", "Freedom", "Indulgence", "Might"),
                "Desna" => Filter(fonts, "Dreams", "Luck", "Moon", "Star", "Travel", "Void"),
                "Erastil" => Filter(fonts, "Duty", "Earth", "Family", "Nature", "Wealth"),
                "Gorum" => Filter(fonts, "Confidence", "Destruction", "Might", "Zeal"),
                "Gozreh" => Filter(fonts, "Air", "Cold", "Lightning", "Nature", "Travel", "Water"),
                "Iomedae" => Filter(fonts, "Confidence", "Duty", "Might", "Truth", "Zeal"),
                "Irori" => Filter(fonts, "Change", "Knowledge", "Might", "Perfection", "Truth", "Vigil"),
                "Lamashtu" => Filter(fonts, "Change", "Family", "Might", "Nightmares", "Trickery"),
                "Nethys" => Filter(fonts, "Destruction", "Glyph", "Knowledge", "Magic", "Protection"),
                "Norgorber" => Filter(fonts, "Death", "Secrecy", "Trickery", "Wealth"),
                "Pharasma" => Filter(fonts, "Death", "Fate", "Healing", "Knowledge", "Soul", "Time", "Vigil"),
                "Rovagug" => Filter(fonts, "Air", "Destruction", "Earth", "Swarm", "Void", "Zeal"),
                "Sarenrae" => Filter(fonts, "Fire", "Healing", "Repose", "Sun", "Truth"),
                "Shelyn" => Filter(fonts, "Creation", "Family", "Passion", "Protection", "Repose" ),
                "Torag" => Filter(fonts, "Creation", "Duty", "Earth", "Family", "Protection"),
                "Urgathoa" => Filter(fonts, "Decay", "Indulgence", "Magic", "Might", "Swarm", "Undeath"),
                "Zon-Kuthon" => Filter(fonts, "Ambition", "Darkness", "Destruction", "Pain", "Void"),
                _ => Array.Empty<Domain>()
            };
        }

        private static Domain[] Filter(Domain[] domains, params string[] domainNames)
        {
            Domain[] matches = domains
                .Where(domain => domainNames.Contains(domain.Name))
                .ToArray();

            return matches.Length == domainNames.Length
                ? matches
                : throw new InvalidOperationException($"Not all domain names could be found: {string.Join(", ", matches.Select(e => e.Name).GetMissing(domainNames))}");
        }
    }
}
